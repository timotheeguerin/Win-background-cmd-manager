using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
        }

        public void start()
        {
            running = true;

            process = new Process();

            // Redirect the output stream of the child process.
            process.StartInfo.UseShellExecute = false;

            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.FileName = "C:/dev/test.bat";
            process.OutputDataReceived += new DataReceivedEventHandler(handleOutput);
            process.Start();
            process.BeginOutputReadLine();

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
            process.Kill();
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
    }
}
