using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayı_Bulma_Oyunu
{
    class Operation
    {
        public static Operation obj = new Operation();
        public int[] randNumRepetitive;
        public int[] randNumUnrepeated;
        Random rand = new Random();
        private int score, winControl,right;
        Label[] labels = new Label[] {Start.obj.lbl_num1,
            Start.obj.lbl_num2, Start.obj.lbl_num3, Start.obj.lbl_num4,
            Start.obj.lbl_num5, Start.obj.lbl_num6, Start.obj.lbl_num7,
            Start.obj.lbl_num8, Start.obj.lbl_num9, Start.obj.lbl_num10 };

        public int getScore()
        {
            return score;
        }
        public void setScore(int getScore)
        {
            score = getScore;
        }
        public int getRight()
        {
            return right;
        }
        public void setRight(int getRight)
        {
            right = getRight;
        }
        public void createRandNumRepetitive(int number)
        {
            randNumRepetitive = new int[number];
            for (int j = 0; j < randNumRepetitive.Length; j++)
            {
            letsgo:
                randNumRepetitive[j] = rand.Next(0, 10);
                if (randNumRepetitive[0] == 0)
                    goto letsgo;
                for (int i = 0; i < j; i++)
                {
                    if (randNumRepetitive[j] == randNumRepetitive[i])
                    {
                        goto letsgo;
                    }
                }
            }
        }
        public void createRandNumUnrepeated(int number)
        {
            randNumUnrepeated = new int[number];
            for (int j = 0; j < randNumUnrepeated.Length; j++)
            {
            letsgo:            
                randNumUnrepeated[j] = rand.Next(0, 10);
                if (randNumUnrepeated[0] == 0)
                    goto letsgo;
            }
        }
        public void controlToEqual(string numberText)
        {
            int num = numberText.Length;

            for (int i = 0; i < num; i++)
            {
                if(labels[i].ForeColor != Color.DeepSkyBlue)
                    labels[i].ForeColor = Color.Black;
            }

            for (int i = 0; i < num; i++)
            {
                labels[i].Text = numberText[i].ToString();
                labels[i].Visible = true;
                if (Start.obj.cBoxRepetitive.Checked == true && Start.obj.cBoxUnrepeated.Checked == false)
                {
                    if (Convert.ToInt32(numberText[i].ToString()) == randNumUnrepeated[i])
                    {
                        if (labels[i].ForeColor != Color.DeepSkyBlue)
                        {
                            winControl += 1;
                            setScore(getScore() + 10);
                        }
                        labels[i].ForeColor = Color.DeepSkyBlue;
                    }
                    else
                    {
                        int b = 0;
                        foreach(char item in numberText)
                        {
                            if (randNumUnrepeated[i] == Convert.ToInt32(item.ToString()))
                                labels[b].ForeColor = Color.Red;
                            b++;
                        }
                        if(score > 0)
                            setScore(getScore() - 1);
                    }
                }
                else
                {
                    if (Convert.ToInt32(numberText[i].ToString()) == randNumRepetitive[i])
                    {
                        if (labels[i].ForeColor != Color.DeepSkyBlue)
                        {
                            winControl += 1;
                            setScore(getScore() + 10);
                        }
                        labels[i].ForeColor = Color.DeepSkyBlue;
                    }
                    else
                    {
                        int b = 0;
                        foreach (char item in numberText)
                        {
                            if (randNumRepetitive[i] == Convert.ToInt32(item.ToString()))
                                labels[b].ForeColor = Color.Red;
                            b++;
                        }
                        if (score > 0)
                            setScore(getScore() - 1);
                    }
                }
                if (winControl == num)
                {
                    Start.obj.lbl_score.Text = "Skor : " + score.ToString();
                    controlWin();
                }
            }
            setRight(getRight() - 1);
            Start.obj.lbl_score.Text = "Skor : " + score.ToString();
            Start.obj.lbl_right.Text = "Kalan Hak : " + right.ToString();
        }
        public void controlToLabel(int numberText)
        {
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Visible = false;
            }
            for (int i = 0; i < numberText; i++)
            {
                labels[i].Visible = true;
            }
        }
        public void controlWin ()
        {
            Start.obj.timer1.Enabled = false;
            Start.obj.btn_try.Enabled = false;
            Start.obj.txt_numPredicted.Enabled = false;
            MessageBox.Show("Oyunu Kazandınız!", "Tebrikler", MessageBoxButtons.OK);
            Score.obj.Show();
        }
        public void controlLost()
        {
            Start.obj.btn_try.Enabled = false;
            Start.obj.txt_numPredicted.Enabled = false;
            MessageBox.Show("Oyunu Kaybettiniz!", ":'(", MessageBoxButtons.OK);
            Score.obj.Show();
        }
    }
}
