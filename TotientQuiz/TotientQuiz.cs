using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 画像：frame-illust.com より*/
namespace TotQuiz
{
    public partial class TotientQuiz : Form
    {

        static int numOfJoiner = 6;
        int preAt;
        int prePoint;
        string appPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        PictureBox[] pictureBoxes = new PictureBox[numOfJoiner]; /* 画像 */
        TextBox[] rankBoxes = new TextBox[numOfJoiner];  /* 順位 */
        TextBox[] joinerBoxes = new TextBox[numOfJoiner]; /* 参加者名 */
        TextBox[] pointBoxes = new TextBox[numOfJoiner]; /* ポイント */
        TextBox[] rightBoxes = new TextBox[numOfJoiner]; /* 正解数 */
        TextBox[] wrongBoxes = new TextBox[numOfJoiner]; /* 不正解数 */
        Button[] rightButtons = new Button[numOfJoiner]; /* 〇ボタン */
        Button[] wrongButtons = new Button[numOfJoiner]; /* ×ボタン */
        public TotientQuiz()
        {
            InitializeComponent();
        }

        private void TotientQuiz_Load(object sender, EventArgs e)
        {
            returnButton.Enabled = false;
            yokokuBox.Text = "1";
            this.SuspendLayout();
            /* pictureBox */
            for(int i = 0; i < numOfJoiner; i++)
            {
                pictureBoxes[i] = new PictureBox();
                pictureBoxes[i].Name = "PictureBox" + i.ToString();
                pictureBoxes[i].Size = new Size(100,55);
                pictureBoxes[i].SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxes[i].Location = new Point(2, 43+59*i);
            }
            /* rankBox */
            for (int i = 0; i < numOfJoiner; i++)
            {
                rankBoxes[i] = new TextBox();
                rankBoxes[i].Name = "RankBox" + i.ToString();
                rankBoxes[i].Size = new Size(75, 47);
                rankBoxes[i].Location = new Point(106, 47 + 59 * i);
                var textBox = rankBoxes[i];
                textBox.Font = new Font(textBox.Font.FontFamily, 30);
            }
            /* joinerBox */
            for (int i = 0; i < numOfJoiner; i++)
            {
                joinerBoxes[i] = new TextBox();
                joinerBoxes[i].Name = "JoinerBox" + i.ToString();
                joinerBoxes[i].Size = new Size(198, 46);
                joinerBoxes[i].Location = new Point(200, 47 + 59 * i);
                joinerBoxes[i].TextAlign = HorizontalAlignment.Left;
                joinerBoxes[i].Multiline = true;
                var textBox = joinerBoxes[i];
                textBox.Font = new Font(textBox.Font.FontFamily, 24);
            }
            /* pointBox */
            for (int i = 0; i < numOfJoiner; i++)
            {
                pointBoxes[i] = new TextBox();
                pointBoxes[i].Name = "PointBox" + i.ToString();
                pointBoxes[i].Size = new Size(108, 47);
                pointBoxes[i].Location = new Point(422, 47 + 59 * i);
                pointBoxes[i].Text = "0";
                pointBoxes[i].TextAlign = HorizontalAlignment.Center;
                var textBox = pointBoxes[i];
                textBox.Font = new Font(textBox.Font.FontFamily, 30);
            }
            /* rightBox */
            for (int i = 0; i < numOfJoiner; i++)
            {
                rightBoxes[i] = new TextBox();
                rightBoxes[i].Name = "RightBox" + i.ToString();
                rightBoxes[i].Size = new Size(69, 41);
                rightBoxes[i].Location = new Point(655, 47 + 59 * i);
                rightBoxes[i].Text = "0";
                rightBoxes[i].TextAlign = HorizontalAlignment.Center;
                var textBox = rightBoxes[i];
                textBox.Font = new Font(textBox.Font.FontFamily, 30);
            }
            /* wrongBox */
            for (int i = 0; i < numOfJoiner; i++)
            {
                wrongBoxes[i] = new TextBox();
                wrongBoxes[i].Name = "WrongBox" + i.ToString();
                wrongBoxes[i].Size = new Size(69, 41);
                wrongBoxes[i].Location = new Point(856, 47 + 59 * i);
                wrongBoxes[i].Text = "0";
                wrongBoxes[i].TextAlign = HorizontalAlignment.Center;
                var textBox = wrongBoxes[i];
                textBox.Font = new Font(textBox.Font.FontFamily, 30);
            }
            /* rightButton */
            for (int i = 0; i < numOfJoiner; i++)
            {
                rightButtons[i] = new Button();
                rightButtons[i].Name = "RightButton" + i.ToString();
                rightButtons[i].BackColor = Color.White;
                rightButtons[i].ForeColor = Color.DeepPink;
                rightButtons[i].Size = new Size(69, 41);
                rightButtons[i].AutoSize = true;
                rightButtons[i].Location = new Point(551, 47 + 59 * i);
                rightButtons[i].Text = "〇";
                rightButtons[i].TextAlign = ContentAlignment.MiddleCenter;
                var buttonText = rightButtons[i];
                buttonText.Font = new Font(buttonText.Font.FontFamily, 26, FontStyle.Bold);
                rightButtons[i].Click += new EventHandler(this.rightButtons_Click);
            }
            /* wrongButton */
            for (int i = 0; i < numOfJoiner; i++)
            {
                wrongButtons[i] = new Button();
                wrongButtons[i].Name = "WrongButton" + i.ToString();
                wrongButtons[i].BackColor = Color.White;
                wrongButtons[i].ForeColor = Color.RoyalBlue;
                wrongButtons[i].Size = new Size(69, 41);
                wrongButtons[i].AutoSize = true;
                wrongButtons[i].Location = new Point(752, 47 + 59 * i);
                wrongButtons[i].Text = "×";
                wrongButtons[i].TextAlign = ContentAlignment.MiddleCenter;
                var buttonText = wrongButtons[i];
                buttonText.Font = new Font(buttonText.Font.FontFamily, 26, FontStyle.Bold);
                wrongButtons[i].Click += new EventHandler(this.wrongButtons_Click);
            }
            this.Controls.AddRange(pictureBoxes);
            this.Controls.AddRange(rankBoxes);
            this.Controls.AddRange(joinerBoxes);
            this.Controls.AddRange(pointBoxes);
            this.Controls.AddRange(rightBoxes);
            this.Controls.AddRange(wrongBoxes);
            this.Controls.AddRange(rightButtons);
            this.Controls.AddRange(wrongButtons);
            this.ResumeLayout(false);
            
        }

        private String ToRankingFormat(int a)
        {
            if     (a % 10 == 1)
                return a + "st";
            else if(a % 10 == 2)
                return a + "nd";
            else if(a % 10 == 3)
                return a + "rd";
            else
                return a + "th";
        }
        /* Decide Ranking */
        private void DecideRanking()
        {
            int[] points = new int[numOfJoiner];
            for(int i = 0; i < numOfJoiner; i++)
            {
                points[i] = Int32.Parse(pointBoxes[i].Text);
            }
            //各値を拾ってランキングを決定して返す
            Dictionary<int, int> rankingMap = CreatedRankingMap(points);
            for(int i = 0; i < numOfJoiner; i++)
            {
                rankBoxes[i].Text = ToRankingFormat(rankingMap[points[i]]);
            }

            for(int i = 0; i < numOfJoiner; i++)
            {
                pictureBoxes[i].ImageLocation = null;
            }
            int count = 0;
            for(int j = 1; j <= 3; j++)
            {
                if (count > 2) break;
                for (int i = 0; i < numOfJoiner; i++)
                {
                    if (count > 3) break;
                    if (rankingMap[points[i]] == j && count < 3)
                    {
                        if(j == 1)
                            pictureBoxes[i].ImageLocation = appPath + "/../img/gold.png";
                        else if (j == 2)
                            pictureBoxes[i].ImageLocation = appPath + "/../img/silver.png";
                        else if (j == 3)
                            pictureBoxes[i].ImageLocation = appPath + "/../img/bronze.png";
                        count++;
                    }
                }
            }

            /* If NumOfProblem > 100 */
            if (nowNumOfProblem.Value >= 1 && nowNumOfProblem.Value <= 100)
            {
                nowNumOfProblem.Enabled = true;
                for(int i = 0; i < numOfJoiner; i++)
                {
                    rightButtons[i].Enabled = true;
                    wrongButtons[i].Enabled = true;
                }
            }
            else
            {
                nowNumOfProblem.Enabled = false;
                for (int i = 0; i < numOfJoiner; i++)
                {
                    rightButtons[i].Enabled = false;
                    wrongButtons[i].Enabled = false;
                }
            }
            int nextPoint = CountGcd1( Decimal.ToInt32(nowNumOfProblem.Value) );
            if (nowNumOfProblem.Value >= 1 && nowNumOfProblem.Value <= 100)
                yokokuBox.Text = nextPoint.ToString();
            else
                yokokuBox.Text = "---";
        }

        /* ranking map */
        private Dictionary<int, int> CreatedRankingMap(int[] a)
        {
            /* sort smaller */
            int[] pointDesc = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                pointDesc[i] = a[i];
            Array.Sort(pointDesc);
            Array.Reverse(pointDesc);
            /* prepare ranking map */
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(pointDesc[i]);

            int rank = 1;
            map.Add(pointDesc[0], rank);
            for (int i = 1; i < a.Length; i++)
            {
                if (pointDesc[i] != pointDesc[i - 1])
                {
                    /* pD[i] > pd[i-1] */
                    rank = i + 1;
                }
                if (!map.ContainsKey(pointDesc[i]))
                    map.Add(pointDesc[i], rank);
            }

            return map;
        }
        /* calcurate gcd */
        private int Gcd(int a, int b)
        {
            if (a % b == 0)
                return b;
            else
                return Gcd(b, a % b);
        }
        /* count gcd = 1 */
        private int CountGcd1(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
                if (Gcd(i, n) == 1) count++;
            return count;
        }
        private void returnButton_Click(object sender, EventArgs e)
        {
            int tmpPoint;
            tmpPoint = Int32.Parse(pointBoxes[preAt].Text);
            pointBoxes[preAt].Text = prePoint.ToString();
            if (tmpPoint > prePoint) /* right answer */
            {
                int tmpRightNum = Int32.Parse(rightBoxes[preAt].Text) - 1;
                rightBoxes[preAt].Text = tmpRightNum.ToString();
            }
            else
            {
                int tmpWrongNum = Int32.Parse(wrongBoxes[preAt].Text) - 1;
                wrongBoxes[preAt].Text = tmpWrongNum.ToString();
            }
            nowNumOfProblem.Value--;
            returnButton.Enabled = false;
            DecideRanking();

        }
        private void rightButtons_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < numOfJoiner; i++)
            {
                if(sender == rightButtons[i])
                {
                    int tmp = Int32.Parse(pointBoxes[i].Text);
                    prePoint = tmp;
                    preAt = i;
                    tmp += CountGcd1(Decimal.ToInt32(nowNumOfProblem.Value));
                    pointBoxes[i].Text = tmp.ToString();
                    /* add right num */
                    int tmp2 = Int32.Parse(rightBoxes[i].Text) + 1;
                    rightBoxes[i].Text = tmp2.ToString();
                    nowNumOfProblem.Value++;
                    DecideRanking();
                    returnButton.Enabled = true;
                }
            }
        }
        private void wrongButtons_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numOfJoiner; i++)
            {
                if (sender == wrongButtons[i])
                {
                    int tmp = Int32.Parse(pointBoxes[i].Text);
                    prePoint = tmp;
                    preAt = i;
                    tmp -= CountGcd1(Decimal.ToInt32(nowNumOfProblem.Value));
                    pointBoxes[i].Text = tmp.ToString();

                    /* add right num */
                    int tmp2 = Int32.Parse(wrongBoxes[i].Text) + 1;
                    wrongBoxes[i].Text = tmp2.ToString();
                    nowNumOfProblem.Value++;
                    DecideRanking();
                    returnButton.Enabled = true;
                }
            }
        }
        private void nowNumOfProblem_ValueChanged(object sender, EventArgs e)
        {
            yokokuBox.Text = CountGcd1(Decimal.ToInt32(nowNumOfProblem.Value)).ToString();
        }
    }
}