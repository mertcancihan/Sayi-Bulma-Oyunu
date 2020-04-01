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
    public partial class Start : Form
    {
        public static Start obj;
        Random rand = new Random();
        public int numOfDigits=0, randNumOfDigits=0, numOfRight=0,timerNum = 15;
        public string numPredicted, name;

        public Start()
        {
            InitializeComponent();
        }
        private void Start_Load(object sender, EventArgs e)
        {
            createObj();
            numericUpDownEdit();
        }
        void createObj()
        {
            if(obj == null)
            { 
                obj = this;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerNum--;
            lbl_time.Text = "Süre : "+timerNum.ToString();
            if(timerNum == 0)
            {
                timerNum = 16;
                numOfRight -= 1;
                lbl_right.Text = "Kalan Hak : " + numOfRight.ToString();
            }
            if (numOfRight == 0)
            {
                timer1.Enabled = false;
                Operation.obj.controlLost();
            }          
            
        }
        private void btn_NumOfDigits_Click(object sender, EventArgs e)
        {
            numOfDigits = Convert.ToInt32(numeric_NumOfDigits.Text);
            lbl_basNum.Text = "Basamak Sayısı : " + numOfDigits.ToString();
            Operation.obj.createRandNumRepetitive(numOfDigits);
            Operation.obj.createRandNumUnrepeated(numOfDigits);
            Operation.obj.controlToLabel(numOfDigits);
        }
        private void numericUpDownEdit()
        {
            numeric_NumOfDigits.Minimum = 2;
            numeric_NumOfDigits.Maximum = 10;
            numeric_choseRight.Minimum = 5;
            numeric_choseRight.Maximum = 15;
        }
        private void btn_RandNumOfDigits_Click(object sender, EventArgs e)
        {
            randNumOfDigits = rand.Next(2, 10);
            Operation.obj.createRandNumRepetitive(randNumOfDigits);
            Operation.obj.createRandNumUnrepeated(randNumOfDigits);
            Operation.obj.controlToLabel(randNumOfDigits);

            lbl_basNum.Text = "Basamak Sayısı : " + randNumOfDigits.ToString();
        }        
        private void btn_try_Click(object sender, EventArgs e)
        {
            numPredicted = txt_numPredicted.Text;
            if (numOfRight == 0)
            {
                Operation.obj.controlLost();
            }
            else if (numPredicted.Length == randNumOfDigits || numPredicted.Length == numOfDigits)
            {
                Operation.obj.controlToEqual(numPredicted);
                numOfRight -= 1;
                timerNum = 16;
            }
            else
                MessageBox.Show("Lütfen Belirtilen Basamak Sayısına Uygun Sayı Giriniz!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txt_numPredicted.Clear();
        }
        private void txt_numPredicted_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btn_Start_Click(object sender, EventArgs e)
        {
            if ((cBoxRepetitive.Checked == false && cBoxUnrepeated.Checked == true || cBoxRepetitive.Checked == true && cBoxUnrepeated.Checked == false)
                && (numOfDigits != 0 || randNumOfDigits != 0) && string.IsNullOrWhiteSpace(txt_name.Text) == false)
            {
                numOfRight = Convert.ToInt32(numeric_choseRight.Text);
                Operation.obj.setRight(numOfRight);
                name = txt_name.Text;
                btn_NumOfDigits.Enabled = false;
                btn_RandNumOfDigits.Enabled = false;
                cBoxUnrepeated.Enabled = false;
                cBoxRepetitive.Enabled = false;
                numeric_choseRight.Enabled = false;
                numeric_NumOfDigits.Enabled = false;
                lbl_getNum.Visible = true;
                txt_numPredicted.Visible = true;
                btn_try.Visible = true;
                txt_name.Enabled = false;
                lbl_right.Visible = true;
                lbl_score.Visible = true;
                lbl_right.Text = "Kalan Hak : " + numOfRight.ToString();
                lbl_basNum.Visible = true;
                btn_Start.Enabled = false;
                timer1.Enabled = true;
                lbl_time.Visible = true;
            }
            else
                MessageBox.Show("Lütfen Yukarıda Gerekli İşlemleri Yapınız!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btn_Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void cBoxRepetitive_CheckedChanged(object sender, EventArgs e)
        {
            if(cBoxRepetitive.Checked == true)
                cBoxUnrepeated.Checked = false;
        }
        private void cBoxUnrepeated_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxUnrepeated.Checked == true)
                cBoxRepetitive.Checked = false;           
        }               
        public void restartGame()
        {
            Application.Restart();
        }
    }
}
