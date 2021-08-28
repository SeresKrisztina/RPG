using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_Big_Project
{
    class Model:IModel
    {
        public Random r = new Random();
        public int hp = 1000;
        public int maxhp = 1000;
        public int xp = 0;
        public int maxxp = 100;
        public int sp = 100;
        public int maxsp = 100;
        public int level = 1;
        public int kp = 0;
        public double[] pposition = new double[2];
        public List<double[]> fa1 = new List<double[]>();
        public List<double[]> fa0 = new List<double[]>();
        public List<double[]> fu = new List<double[]>();
        public List<double[]> kisvirag = new List<double[]>();
        public List<double[]> ronk = new List<double[]>();
        public List<double[]> kicsifa = new List<double[]>();
        public List<double[]> slime = new List<double[]>();
        public List<int> slimehp = new List<int>();
        public void fagen(List<double[]> tomb)
        {
            double szam1 = r.Next(-50000, 50000);
            double szam2 = r.Next(-50000, 50000);
            szam1 = szam1 / 10000;
            szam2 = szam2 / 10000;
            double[] d = new double[2];
            d[0] = szam1;
            d[1] = szam2;
            tomb.Add(d);
        }
    }
}
