using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayı_Bulma_Oyunu
{
    public partial class Score : Form
    {
        public static Score obj = new Score();
        public Score()
        {
            InitializeComponent();
        }
        private void Score_Load(object sender, EventArgs e)
        {
            createObj();
            Database.obj.showScoreList(listboxScore);
        }
        private void createObj()
        {
            if (obj == null)
                obj = this;
        }
        private void btn_restart_Click(object sender, EventArgs e)
        {
            Start.obj.restartGame();
            this.Hide();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            Start.obj.Close();
        }
        private void btn_score_Click(object sender, EventArgs e)
        {
            Database.obj.showScoreList(listboxScore);
            Database.obj.saveToScore(listboxScore);
            Database.obj.showScoreList(listboxScore);
            listboxScore.Visible = true;
            label1.Visible = true;
            btn_score.Visible = false;
        }
    }
}
