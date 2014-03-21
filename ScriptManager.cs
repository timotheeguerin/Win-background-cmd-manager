using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace CmdInTray
{
    class ScriptManager
    {
        public event EventHandler scriptOutputReceived;
        public delegate void EventHandler(Script script, String e);


        private static ScriptManager manager;
        private String saveFileName = "save.json";
        public List<Script> scripts = new List<Script>();

        private ScriptManager()
        {
        }

        public static ScriptManager instance()
        {
            if (manager == null)
            {
                Console.Write("NUll");
                manager = new ScriptManager();
            }
            return manager;
        }

        public void init()
        {
            if (!System.IO.Directory.Exists(Script.log_dir))
            {
                System.IO.Directory.CreateDirectory(Script.log_dir);
            }
            load();
        }

        //Stop all running scripts
        public void clean()
        {
            foreach (Script script in scripts)
            {
                script.stop();
            }
        }

        private void load()
        {
            Save save = Save.load(saveFileName);
            this.scripts = save.scripts;
            Script.next_id = save.next_id;
        }

        public void reload()
        {
            load();
        }

        public void save()
        {
            Save save = new Save(scripts);
            save.save(saveFileName);
        }

        public void handleScriptOutput(Script script, String text)
        {
            if (scriptOutputReceived != null)
            {
                scriptOutputReceived(script, text);
            }
        }

        public static void KillAllProcessesSpawnedBy(UInt32 parentProcessId)
        {
            Console.WriteLine("Finding processes spawned by process with Id [" + parentProcessId + "]");

            // NOTE: Process Ids are reused!
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(
                "SELECT * " +
                "FROM Win32_Process " +
                "WHERE ParentProcessId=" + parentProcessId);
            ManagementObjectCollection collection = searcher.Get();
            if (collection.Count > 0)
            {
                Console.WriteLine("Killing [" + collection.Count + "] processes spawned by process with Id [" + parentProcessId + "]");
                foreach (var item in collection)
                {
                    UInt32 childProcessId = (UInt32)item["ProcessId"];
                    if ((int)childProcessId != Process.GetCurrentProcess().Id)
                    {
                        KillAllProcessesSpawnedBy(childProcessId);

                        Process childProcess = Process.GetProcessById((int)childProcessId);
                        Console.WriteLine("Killing child process [" + childProcess.ProcessName + "] with Id [" + childProcessId + "]");
                        childProcess.Kill();
                    }
                }
            }
        }

    }
}
