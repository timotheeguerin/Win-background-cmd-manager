using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdInTray
{
    class Script
    {
        //Counter to keep unique ids
        public static int next_id = 3;

        public int id;
        public String name;
        public String command;

        public Script()
        {
            id = next_id;
            next_id++;
        }

        public void start()
        {

        }

        public void stop()
        {

        }

        public void restart()
        {
            stop();
            restart();
        }

        public Boolean isRunning()
        {
            return true;
        }
    }
}
