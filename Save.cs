using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdInTray
{
    class Save
    {
        public int next_id = Script.next_id;
        public List<Script> scripts = new List<Script>();

        public Save()
        {
        }

        public Save(List<Script> scripts)
        {
            this.scripts = scripts;
        }

        public static Save load(String filename)
        {
            if (System.IO.File.Exists(filename))
            {
                string json = System.IO.File.ReadAllText(filename);
                return fromJson(json);
            }
            else
            {
                return new Save();
            }
        }

        public static Save fromJson(String json)
        {
            return JsonConvert.DeserializeObject<Save>(json);
        }

        public String toJson()
        {
            return JsonConvert.SerializeObject(this);

        }

        public void save(String filename)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(filename);
            file.WriteLine(this.toJson());
            file.Close();
        }
    }
}
