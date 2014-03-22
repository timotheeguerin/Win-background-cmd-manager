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
            System.IO.StreamWriter file = System.IO.File.AppendText(getLogFileName());
            file.WriteLine(e.Data);
            file.Close();

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
            List<string> buffer = new List<string>(lineCount);
            TextReader reader = File.OpenText(getLogFileName());
            string line;
            for (int i = 0; i < lineCount; i++)
            {
                line = reader.ReadLine();
                if (line == null)
                {
                    return string.Join("\n", buffer);
                }
                buffer.Add(line);
            }

            int lastLine = lineCount - 1;           //The index of the last line read from the buffer.  Everything > this index was read earlier than everything <= this indes

            while (null != (line = reader.ReadLine()))
            {
                lastLine++;
                if (lastLine == lineCount) lastLine = 0;
                buffer[lastLine] = line;
            }

            if (lastLine == lineCount - 1)
            {
                return string.Join("\n", buffer);
            }
            var retVal = new string[lineCount];
            buffer.CopyTo(lastLine + 1, retVal, 0, lineCount - lastLine - 1);
            buffer.CopyTo(0, retVal, lineCount - lastLine - 1, lastLine + 1);
            return string.Join("\n", retVal);
        }


    }
}
