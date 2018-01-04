using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Settings
{
    class PlayerSettings
    {
        public static bool overlay, sumthingelse;

        public static void set(ref bool setting, int value)
        {
            if (value == 1)
            {
                setting = true;
            }

            else
            {
                setting = false;
            }
        }

        public void load()
        {

        }
    }
}
