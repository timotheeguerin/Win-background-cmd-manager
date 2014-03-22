using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace CmdInTray
{

    class Script
    {

        public delegate void DataReceivedHandler(object sender,
        DataReceivedEventArgs e);

        public event DataReceivedHandler StdOutReceived;


        //Counter to keep unique ids
        public static int next_id = 3;

        public int id;
        public String name;
        public String command;
        public String working_directory;
        public Boolean auto_start;

        private Boolean running;

        private Process process;

        public static String log_dir = "logs/scripts/";


        public Script()
        {
            id = next_id;
            next_id++;
            running = false;
            name = "";
            command = "";
            working_directory = "";
            auto_start = false;
        }

        public void start()
        {
            running = true;

            process = new Process();

            // Redirect the output stream of the child process.
            process.StartInfo.UseShellExecute = false;

            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.FileName = @"cmd";
            process.StartInfo.Arguments = "/C " + command;
            process.StartInfo.WorkingDirectory = working_directory;
            Console.WriteLine("WD : " + working_directory);
            Console.WriteLine("Start info: " + process.StartInfo.WorkingDirectory);
            process.OutputDataReceived += new DataReceivedEventHandler(handleOutput);
            try
            {
                process.Start();
                process.BeginOutputReadLine();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                running = false;
            }


        }

        private void handleOutput(object sender, DataReceivedEventArgs e)
        {
            try
            {
                System.IO.StreamWriter file = System.IO.File.AppendText(getLogFileName());
                file.WriteLine(e.Data);
                file.Close();
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            

            ScriptManager.instance().handleScriptOutput(this, e.Data);
        }


        public void stop()
        {
            running = false;
            try
            {
                if (process != null && !process.HasExited)
                {
                    ScriptManager.KillAllProcessesSpawnedBy(Convert.ToUInt32(process.Id));
                    process.Kill();
                }
            }
            catch (System.InvalidOperationException e)
            {
                Console.Write("Error: " + e.Message);
            }
        }

        public void restart()
        {
            stop();
            restart();
        }

        public Boolean isRunning()
        {
            return running;
        }

        private String getLogFileName()
        {
            return "logs/scripts/" + name + ".log";

        }

        public string getLastLines()
        {
            if (!File.Exists(getLogFileName()))
            {
                return "";
            }
            int lineCount = 20;
            Encoding encoding = Encoding.Default;
            string tokenSeparator = "\n";
            int sizeOfChar = encoding.GetByteCount("\n");
            byte[] buffer = encoding.GetBytes(tokenSeparator);


            using (FileStream fs = new FileStream(getLogFileName(), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                Int64 tokenCount = 0;
                Int64 endPosition = fs.Length / sizeOfChar;

                for (Int64 position = sizeOfChar; position < endPosition; position += sizeOfChar)
                {
                    fs.Seek(-position, SeekOrigin.End);
                    fs.Read(buffer, 0, buffer.Length);

                    if (encoding.GetString(buffer) == tokenSeparator)
                    {
                        tokenCount++;
                        if (tokenCount == lineCount)
                        {
                            byte[] returnBuffer = new byte[fs.Length - fs.Position];
                            fs.Read(returnBuffer, 0, returnBuffer.Length);
                            return encoding.GetString(returnBuffer);
                        }
                    }
                }

                // handle case where number of tokens in file is less than numberOfTokens
                fs.Seek(0, SeekOrigin.Begin);
                buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                return encoding.GetString(buffer);
            }
        }

        public Boolean isAutoStart()
        {
            return auto_start;
        }


    }
}
