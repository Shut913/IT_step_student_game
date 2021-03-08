using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bojko_Tarasenko_exam.Classes;

namespace Bojko_Tarasenko_exam
{
    public partial class MainForm : Form
    {
        private Player player;
        private DateTime gameTime;
        private DateTime prevGameTime;
        private MouseEventArgs mousePos;
        private List<GameLocation> gameLocations;
        private GameLocation currentGameLocation;
        private InteractionItem currentInteractionItem;
        private int _indent=0;
        WMPLib.WindowsMediaPlayer wplayer;

        public MainForm()
        {
            InitializeComponent();
            player = new Player("Vasya", 50, 60, 70, 80, 50,100, 500);
            gameTime = new DateTime(2019, 11, 15, 8, 0, 0);
            prevGameTime = gameTime;
            gameLocations = GenerateLocations();
            currentGameLocation = gameLocations[0];
            wplayer = new WMPLib.WindowsMediaPlayer();
            
            wplayer.URL = Path.GetFullPath(@"..\..\Music\Chillhop.mp3");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowLocation();
            ShowPlayerCharacteristics();
            ShowGameTime();
            FillInteractionLabels();
            wplayer.controls.play();
        }
        private void ShowLocation()
        {
            pnlLocation.BackgroundImage = Image.FromFile(currentGameLocation._image);
            lblLocationName.Text = currentGameLocation.Name;
        }

        private void ShowPlayerCharacteristics()
        {
            lblName.Text = player.Name;
            lblSatiety.Text = Convert.ToInt32(player.Satiety).ToString();
            lblCheer.Text = Convert.ToInt32(player.Cheerfulness).ToString();
            lblHygiene.Text = Convert.ToInt32(player.Hygiene).ToString();
            lblIntellect.Text = Convert.ToInt32(player.Intelligence).ToString();
            lblMood.Text = Convert.ToInt32(player.Mood).ToString();
            lblMoney.Text = player.Money.ToString();
        }

        private void ShowGameTime()
        {
            List<string> dayOfWeek = new List<string> { " (Вс)", " (Пн)", " (Вт)", " (Ср)", " (Чт)", " (Пт)", " (Сб)"};

            lblDate.Text = gameTime.ToString("MM/dd/yyyy") + dayOfWeek[(int)gameTime.DayOfWeek];
            lblTime.Text= gameTime.ToString("HH:mm:ss");
        }

        private void pnlLocation_Click(object sender, EventArgs e)
        {
            foreach (InteractionItem interIt in currentGameLocation._interactionItems)
                if (mousePos.X > interIt._posUpperLeft.X &&
                    mousePos.X < interIt._posBottomRight.X &&
                    mousePos.Y > interIt._posUpperLeft.Y &&
                    mousePos.Y < interIt._posBottomRight.Y)
                {
                    currentInteractionItem = interIt;
                    _indent = 0;
                    FillInteractionLabels();
                }

        }
        private void FillInteractionLabels()
        {
            lblItemName.Text = lbl_1line.Text = lbl_2line.Text = lbl_3line.Text = lbl_4line.Text = "";

            int i = 1;
            int index = 0;

            foreach (Control c in pnlSelect.Controls)
                if (c.Tag != null)
                    c.Enabled=false;


            if (currentInteractionItem!=null)
            {
                lblItemName.Text = currentInteractionItem.Name;

                foreach (Interaction inter in currentInteractionItem._interactions)
                {
                    foreach (Control c in pnlSelect.Controls)
                        if (c.Tag != null)
                            if (c.Tag.ToString() == (i - _indent).ToString())
                            {
                                c.Enabled = true;
                                index = pnlSelect.Controls.IndexOf(c);
                                pnlSelect.Controls[index].Text = inter._text;
                            }
                    ++i;
                }
                if (i - _indent > 4)
                    lblForward.Enabled = true;
                else
                    lblForward.Enabled = false;
                if (_indent > 0)
                    lblBack.Enabled = true;
                else
                    lblBack.Enabled = false;
            }
        }
        private void pnlLocation_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X.ToString()+ "; " + e.Y.ToString();
            mousePos = e;
        }

        private void lblLine_MouseEnter(object sender, EventArgs e)
        {
            Label l = sender as Label;
            l.ForeColor = Color.Red;
        }

        private void lblLine_MouseLeave(object sender, EventArgs e)
        {
            Label l = sender as Label;
            l.ForeColor = SystemColors.ControlText;
        }

        private void lbl_line_MouseClick(object sender, MouseEventArgs e)
        {
            Label l = sender as Label;
            if (l.Tag.ToString() == "back")
            {
                _indent -= 4;
                FillInteractionLabels();
            }
            else if (l.Tag.ToString() == "forward")
            {
                _indent += 4;
                FillInteractionLabels();
            }
            else
                ChangePlayerCharacteristics(Convert.ToInt32(l.Tag.ToString()) - 1+_indent);
        }
        private void ChangePlayerCharacteristics(int interactNum)
        {
            foreach (Impact imp in currentInteractionItem._interactions[interactNum]._impact) 
            {
                switch (imp.characteristic)
                {
                    case Characteristic.cheerfulness:
                        player.Cheerfulness += imp.value;
                        break;
                    case Characteristic.hygiene:
                        player.Hygiene += imp.value;
                        break;
                    case Characteristic.intelligence:
                        player.Intelligence += imp.value;
                        break;
                    case Characteristic.mood:
                        player.Mood += imp.value;
                        break;
                    case Characteristic.satiety:
                        player.Satiety += imp.value;
                        break;

                    case Characteristic.money:
                        player.Money += imp.value;
                        break;

                    case Characteristic.time:
                        gameTime=gameTime.AddMinutes(imp.value);
                        ShowGameTime();
                        break;

                    case Characteristic.location:
                        currentGameLocation = gameLocations[imp.value];
                        currentInteractionItem = null;
                        FillInteractionLabels();
                        ShowLocation();
                        break;

                    case Characteristic.mark:
                        if (Study.IsStudyDay(gameTime.DayOfWeek))
                        {
                            player.GetMark();
                            MessageBox.Show($"Вы получили оценку: {player.study.GetLastMark()}");
                        }
                        else
                            MessageBox.Show("Сегодня не учебный день");
                        break;
                }
            }
            ShowPlayerCharacteristics();
        }
        private void checkNullCharacteristics()
        {
            if (player.Cheerfulness.Equals(0)) MessageBox.Show("Вы слишком устали, поспите");
            if (player.Hygiene.Equals(0)) MessageBox.Show("От вас идет неприятный запах, помойтесь");
            if (player.Mood.Equals(0)) MessageBox.Show("У вас плохое настроение, развлекитесь");
            if (player.Satiety.Equals(0)) MessageBox.Show("Вы слишком голодны, поешьте");
        }
        private void timeSecTimer_Tick(object sender, EventArgs e)
        {
            gameTime = gameTime.AddSeconds(1);
            ShowGameTime();

            if ((gameTime - prevGameTime).TotalMinutes >= 5)
            {
                int n = (int)((gameTime-prevGameTime).TotalMinutes / 5);
                prevGameTime = gameTime;

                player.Satiety -= n * 0.3f;
                player.Cheerfulness -= n * 0.3f;
                player.Hygiene -= n * 0.1f;
                player.Intelligence -= n * 0.03f;
                player.Mood -= n * 0.3f;
                ShowPlayerCharacteristics();
                checkNullCharacteristics();
            }
        }

    }
}
