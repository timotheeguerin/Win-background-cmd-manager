using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdInTray
{
    class ScriptManager
    {
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
            load();
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
    }
}
