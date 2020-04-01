using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayı_Bulma_Oyunu
{
    class Database
    {
        public static Database obj = new Database();
        public FileStream fs, fs2;

        public void showScoreList(ListBox listScore)
        {
            listScore.Items.Clear();
            fs = new FileStream(@"scoreList.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("windows-1254"));
            string name = sr.ReadLine();
            while (name != null)
            {
                listScore.Items.Add(name);
                name = sr.ReadLine();
            }
            sr.Close();
        }
        public void saveToScore(ListBox listScore)
        {
            listScore.Items.Add("  " + Operation.obj.getScore() + " --- " + Start.obj.name);
            fs2 = new FileStream(@"scoreList.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter SaveFile = new StreamWriter(fs2, Encoding.GetEncoding("windows-1254"));
            foreach (var item in listScore.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }
            SaveFile.Close();
        }
    }
}
