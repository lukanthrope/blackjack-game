using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack_game
{
    public partial class Gaming : Form
    {
        const int BLACKJACK = 21;
        
        Dictionary<PictureBox, int> cardDict = new Dictionary<PictureBox, int>();
        string[] names = new string[4] { "ви", "казино", "goblin", "CLim Jukov" };
        Player[] players = new Player[4];

        int[,] initialPositions = new int[4, 2] {
            { 50, 570 }, { 480, 378 }, { 300, 450 }, { 700, 455 },
        };

        int numberOfOponents;

        int gamerMoney = 2000;
        int bet = 0;
        public Gaming(string name, int numberOfOponents)
        {
            InitializeComponent();
            MoneyInput.KeyPress += MoneyInputValidator;
            names[0] = name;
            this.numberOfOponents = numberOfOponents;
        }

        private void Gaming_Load(object sender, EventArgs e)
        {
            HideCards();
            CreateDict();
            ResetPositions();
            
            money.Text = gamerMoney.ToString();
            username.Text = names[0];
            pictureTable.Controls.Add(pictureCrupie);
            pictureTable.Controls.Add(pictureGoblin);
            pictureTable.Controls.Add(pictureClim);

            pictureCrupie.Location = new Point(270, 0);
            pictureGoblin.Location = new Point(20, 80);
            pictureClim.Location = new Point(500, 130);

            pictureCrupie.BackColor = Color.Transparent;
            pictureGoblin.BackColor = Color.Transparent;
            pictureClim.BackColor = Color.Transparent;

            goblinSays.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        private void ResetPositions()
        {
            int[] tempArr = new int[2]
           {
                initialPositions[0, 0], initialPositions[0, 1]
           };

            players[0] = new Player(names[0], tempArr);

            tempArr = new int[2]
            {
                initialPositions[1, 0], initialPositions[1, 1]
            };
            players[1] = new Player(names[1], tempArr, cropieSays, cropieText);

            if (numberOfOponents < 2)
            {
                pictureGoblin.Visible = false;
            }

            tempArr = new int[2]
            {
                initialPositions[2, 0], initialPositions[2, 1]
            };
            if (numberOfOponents < 3)
            {
                pictureClim.Visible = false;
                players[2] = new Player(names[2], tempArr, goblinSays, goblinText);
            }

            if (numberOfOponents == 3)
            {
                players[2] = new Player(names[2], tempArr, goblinSays, goblinText);
                tempArr = new int[2]
            {
                initialPositions[3, 0], initialPositions[3, 1]
            };
                players[3] = new Player(names[3], tempArr, climSays, climText);
            }
        }

        private void MoneyInputValidator(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
                e.Handled = true;
        }

        private void HideCards()
        {
            twoC.Visible = false;
            twoD.Visible = false;
            twoH.Visible = false;
            twoS.Visible = false;

            threeC.Visible = false;
            threeD.Visible = false;
            threeH.Visible = false;
            threeS.Visible = false;

            fourC.Visible = false;
            fourD.Visible = false;
            fourH.Visible = false;
            fourS.Visible = false;

            fiveC.Visible = false;
            fiveD.Visible = false;
            fiveH.Visible = false;
            fiveS.Visible = false;

            sixC.Visible = false;
            sixD.Visible = false;
            sixH.Visible = false;
            sixS.Visible = false;

            sevenC.Visible = false;
            sevenD.Visible = false;
            sevenH.Visible = false;
            sevenS.Visible = false;

            eightC.Visible = false;
            eightD.Visible = false;
            eightH.Visible = false;
            eightS.Visible = false;

            nineC.Visible = false;
            nineD.Visible = false;
            nineH.Visible = false;
            nineS.Visible = false;

            tenC.Visible = false;
            tenD.Visible = false;
            tenH.Visible = false;
            tenS.Visible = false;

            jackC.Visible = false;
            jackD.Visible = false;
            jackH.Visible = false;
            jackS.Visible = false;

            queenC.Visible = false;
            queenD.Visible = false;
            queenH.Visible = false;
            queenS.Visible = false;

            kingC.Visible = false;
            kingD.Visible = false;
            kingH.Visible = false;
            kingS.Visible = false;

            aceC.Visible = false;
            aceD.Visible = false;
            aceH.Visible = false;
            aceS.Visible = false;

            back.Visible = false;
        }

        private void CreateDict()
        {
            Dictionary<PictureBox, int> cardDict = new Dictionary<PictureBox, int>();
            cardDict.Add(twoC, 2);
            cardDict.Add(twoD, 2);
            cardDict.Add(twoH, 2);
            cardDict.Add(twoS, 2);

            cardDict.Add(threeC, 3);
            cardDict.Add(threeD, 3);
            cardDict.Add(threeH, 3);
            cardDict.Add(threeS, 3);

            cardDict.Add(fourC, 4);
            cardDict.Add(fourD, 4);
            cardDict.Add(fourH, 4);
            cardDict.Add(fourS, 4);

            cardDict.Add(fiveC, 5);
            cardDict.Add(fiveD, 5);
            cardDict.Add(fiveH, 5);
            cardDict.Add(fiveS, 5);

            cardDict.Add(sixC, 6);
            cardDict.Add(sixD, 6);
            cardDict.Add(sixH, 6);
            cardDict.Add(sixS, 6);

            cardDict.Add(sevenC, 7);
            cardDict.Add(sevenD, 7);
            cardDict.Add(sevenH, 7);
            cardDict.Add(sevenS, 7);

            cardDict.Add(eightC, 8);
            cardDict.Add(eightD, 8);
            cardDict.Add(eightH, 8);
            cardDict.Add(eightS, 8);

            cardDict.Add(nineC, 9);
            cardDict.Add(nineD, 9);
            cardDict.Add(nineH, 9);
            cardDict.Add(nineS, 9);

            cardDict.Add(tenC, 10);
            cardDict.Add(tenD, 10);
            cardDict.Add(tenH, 10);
            cardDict.Add(tenS, 10);

            cardDict.Add(jackC, 10);
            cardDict.Add(jackD, 10);
            cardDict.Add(jackH, 10);
            cardDict.Add(jackS, 10);

            cardDict.Add(queenC, 10);
            cardDict.Add(queenD, 10);
            cardDict.Add(queenH, 10);
            cardDict.Add(queenS, 10);

            cardDict.Add(kingC, 10);
            cardDict.Add(kingD, 10);
            cardDict.Add(kingH, 10);
            cardDict.Add(kingS, 10);

            cardDict.Add(aceC, 11);
            cardDict.Add(aceD, 11);
            cardDict.Add(aceH, 11);
            cardDict.Add(aceS, 11);

            this.cardDict = cardDict;
        }

        public static void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MoneyInput.Text.Trim() != "")
            {
                if (Convert.ToInt32(MoneyInput.Text) > gamerMoney)
                {
                    MessageBox.Show("У вас недостатньо коштів");
                } else
                {
                    gamerMoney -= Convert.ToInt32(MoneyInput.Text);
                    money.Text = gamerMoney.ToString();
                    bet = Convert.ToInt32(MoneyInput.Text);

                    HideCards();
                    MoneyInput.Visible = false;
                    button1.Visible = false;
                    label2.Visible = false;

                    cropieSays.Visible = false;
                    cropieText.Visible = false;

                    int i;
                    
                    for (i = 0; i <= numberOfOponents; i++)
                    {
                        if (i == 1)
                        {
                            GetCardsTo(cardDict, players[i].cards, i);
                            wait(200);
                            back.Visible = true;
                            wait(600);
                        } else
                        {
                            GetCardsTo(cardDict, players[i].cards, i);
                            wait(200);
                            GetCardsTo(cardDict, players[i].cards, i);
                            wait(600);
                        }
                        
                    }

                    if (isThereBlackJack())
                    {
                        getWinner();
                    }
                    else
                    {
                        moreCard.Visible = true;
                        enoughButton.Visible = true;
                    }
                }
                
            }
        }

        private PictureBox GetRandomCard(Dictionary<PictureBox, int> dict)
        {
            Random rand = new Random();
            return dict.ElementAt(rand.Next(0, dict.Count)).Key;
        }

        private void GetCardsTo(Dictionary<PictureBox, int> from, Dictionary<PictureBox, int> to, int gamerNumber = 0)
        {
            PictureBox temp = GetRandomCard(from);
            to.Add(temp, from[temp]);
            from.Remove(temp);

            if (FindSum(to) > BLACKJACK)
            {
                if (to.ContainsKey(aceC) && to[aceC] != 1)
                    to[aceC] = 1;
                else if (to.ContainsKey(aceD) && to[aceD] != 1)
                    to[aceD] = 1;
                else if (to.ContainsKey(aceH) && to[aceH] != 1)
                    to[aceH] = 1;
                else if (to.ContainsKey(aceS) && to[aceS] != 1)
                    to[aceS] = 1;
            }
            SetCardPosition(temp, gamerNumber);
            temp.Visible = true;
        }

        private void SetCardPosition(PictureBox card, int num)
        {
            card.Location = new Point(players[num].currentCardPosition[0], players[num].currentCardPosition[1]);
            players[num].currentCardPosition[0] += 40;
        }

        private void MoreCard_Click(object sender, EventArgs e)
        {
            moreCard.Visible = false;
            enoughButton.Visible = false;
            if (cardDict.Count != 0)
                GetCardsTo(cardDict, players[0].cards);

            if (isThereBlackJack())
                getWinner();
            else
            {
                if (FindSum(players[0].cards) > BLACKJACK)
                {
                    players[1].Say("У вас перебор", 1000);
                    enoughButton.Visible = true;
                    enoughButton.PerformClick();
                    
                }
                else
                {
                    BotsTakeCard();
                    enoughButton.Visible = true;
                    moreCard.Visible = true;
                }
            }
        }

        private void EnoughButton_Click(object sender, EventArgs e)
        {
            moreCard.Visible = false;
            enoughButton.Visible = false;
            BotsTakeCard();
            getWinner();
        }

        private void getWinner()
        {
            int max = 0;
            int maxIndex = -1;
            int numOfMax = 1;
            for (int i = 0; i <= numberOfOponents; i++)
            {
                int sum = FindSum(players[i].cards);

                if (sum == max)
                {
                    numOfMax++;
                } else if (sum > max && sum <= BLACKJACK)
                {
                    max = sum;
                    maxIndex = i;
                    numOfMax = 1;
                }
            }

            if (maxIndex == -1 || numOfMax > 1)
                players[1].Say("Виграло казино\nРобіть ставки^^");
            else
                players[1].Say("Виграв " + players[maxIndex].getName() + "\nРобіть ставки^^");
            if (maxIndex == 0 && numOfMax == 1)
            {
                gamerMoney =  gamerMoney + bet * (1 + numberOfOponents);
                money.Text = gamerMoney.ToString();
            }

            CreateDict();
            ResetPositions();
            moreCard.Visible = false;
            enoughButton.Visible = false;

            wait(1000);

            MoneyInput.Visible = true;
            button1.Visible = true;
            label2.Visible = true;
        }

        private bool isThereBlackJack()
        {
            for (int i = 0; i <= numberOfOponents; i++)
            {
                int sum = FindSum(players[i].cards);

                if (sum == BLACKJACK)
                    return true;
            }

            return false;
        }

        private int FindSum(Dictionary<PictureBox, int> dict)
        {
            int sum = 0;
            foreach (var el in dict)
                sum += el.Value;
            return sum;
        }

        private void BotsTakeCard()
        {
            for (int i = 1; i <= numberOfOponents; i++)
            {
                int sum = FindSum(players[i].cards);
                if (sum < 17)
                {
                    if (i == 1)
                        back.Visible = false;

                    if (i != 1)
                        players[i].Say("Візьму ще карту", 1200);
                    GetCardsTo(cardDict, players[i].cards, i);
                    wait(500);

                    BotsTakeCard();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Hide();
            Dashboard dashboard = new Dashboard(players[0].getName(), gamerMoney);
            dashboard.Closed += (object s, EventArgs args) => Close();
            dashboard.Show();
        }
    }
}
