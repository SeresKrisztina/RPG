using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_Big_Project
{
    class Persistance
    {
        public int lastlevel;
        public int Import()
        {
            if (File.Exists("data.txt") == true)
            {
                StreamReader file = new StreamReader("data.txt");
                lastlevel = Convert.ToInt32(file.ReadLine());
                file.Close();
                return lastlevel;
            }
            else
            {
                File.Create("data.txt");
                return 0;
            }

        }
        public void Export(int score)
        {
                StreamWriter file = new StreamWriter("data.txt");
                file.WriteLine(score);
                file.Close();
        }
    }
}
