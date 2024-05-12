using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MarkuStation
{
    public partial class Form1 : Form
    {
        //if forcespecial is true, then v is always 26, thus playing the special intro
        //if forcespecial is false, then v can be randomized
        //if date is October 31st, then creepypasta intro will play 100% of the time
        bool forcespecial = false;
        bool dev = false;
        int clickstate = 0;
        string c = Environment.GetEnvironmentVariable("HOMEDRIVE"); // generally C:
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Intro randomizer
            Random rnd = new Random();
            int v = rnd.Next(100);
            if (forcespecial == true) { v = 26; }
            if (DateTime.Today.Month == 10)
            {
                if (DateTime.Today.Day == 31)
                {
                    v = 13;
                }
            }
            if (v == 13)
            {
                File.WriteAllBytes(c + "\\mas\\ms.wmv", Properties.Resources.MarkuStation_creepy);
                axWMP.URL = c + "\\mas\\ms.wmv";
                startuplabel.Text = "Starting MarkuStation 2016...";
                return;
            }
            else if (v == 26)
            {
                File.WriteAllBytes(c + "\\mas\\ms.wmv", Properties.Resources.MarkuStation_special);
                axWMP.URL = c + "\\mas\\ms.wmv";
                startuplabel.Text = "Starting MarkuStation 2016...";
                return;
            }
            else if (v <= 50)
            {
                File.WriteAllBytes(c + "\\mas\\ms.wmv", Properties.Resources.MarkuStation_original);
                axWMP.URL = c + "\\mas\\ms.wmv";
                startuplabel.Text = "Starting MarkuStation 2015...";
                startuplabel.Visible = false;
                llabel.Visible = false;
                return;
            }
            else if (v > 50)
            {
                File.WriteAllBytes(c + "\\mas\\ms.wmv", Properties.Resources.MarkuStation_2016);
                axWMP.URL = c + "\\mas\\ms.wmv";
                startuplabel.Text = "Starting MarkuStation 2016...";
                return;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWMP.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                //If playback stops, then hide player and show everything else
                axWMP.Visible = false;
                File.Delete(c + "\\mas\\ms.wmv");
                letterM.Visible = true;
                letterS.Visible = true;
                ms.Visible = true;
                mme.Visible = true;
                closebutton.Visible = true;
                btn1.Visible = true;
                minButton.Visible = true;
                rebutton.Visible = true;
                gamegroup.Visible = true;
                //Disables automatically moving cursor
                postimer.Enabled = false;
                //Loads data
                if (dev == true) { MessageBox.Show("Decoding MarkuStation data"); }
                string fl=File.ReadAllText(c + "\\mas\\ms_games.txt", Encoding.ASCII);
                GameList.Items.AddRange(fl.Split('\n'));
                int il = 1;
                if (dev == true) { MessageBox.Show("Starting while loop"); }
                while (il < GameList.Items.Count - 1)
                {
                    GameList.SelectedIndex = il;
                    if (dev == true) { MessageBox.Show("Processing line: " + GameList.SelectedItem.ToString()); }
                    int a = il;
                    if (dev == true) { MessageBox.Show("Searching for btn" + a); }
                    if (dev == true) { MessageBox.Show("Starting new object search..."); }
                    foreach (Control c in this.gamegroup.Controls)
                    {
                        if (c.Name == "Form1") { goto byebye; }
                            if (c.Name.Equals("btn" + a.ToString()))
                            {
                                if (dev == true) { MessageBox.Show("btn" + a + " - match found"); }
                                c.Text = GameList.SelectedItem.ToString();
                            }
                        byebye: ;
                    }
                    if (dev == true) { MessageBox.Show("Increasing il value"); }
                    il = il + 1;
                }
                if (dev == true) { MessageBox.Show("While loop finished, starting foreachloop"); }
                foreach (Control c in this.gamegroup.Controls)
                {
                    if (c is Button)
                    {
                        if (c.Text == "")
                        {
                            c.Visible = false;
                            if (dev == true) { MessageBox.Show(c.ToString() + " is empty"); }
                        }
                        else
                        {
                            c.Visible = true;
                        }
                    }
                }
                GameList.Items.Clear();
                string flu = File.ReadAllText(c + "\\mas\\ms_exec.txt", Encoding.ASCII);
                GameList.Items.AddRange(flu.Split('\n'));
                if (dev == true) { MessageBox.Show("foreach loop ended"); }
                backgroundLoop.Enabled = true;
                //Centers the cursor
                Cursor.Position = new Point(640, 512);
                Cursor.Show();
            }
            else if (axWMP.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                startuplabel.Visible = false;
                llabel.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }

        private void axWindowsMediaPlayer1_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            //User clicked, so end the playback
            if (startuplabel.Visible == false)
            {
                axWMP.Ctlcontrols.stop();
            }
        }

        private void axWindowsMediaPlayer1_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {
           
        }

        private void axWindowsMediaPlayer1_KeyPressEvent(object sender, AxWMPLib._WMPOCXEvents_KeyPressEvent e)
        {
            //Checks if user pressed enter key
            if (startuplabel.Visible == false)
            {
                if (e.nKeyAscii == 13)
                {
                    axWMP.Ctlcontrols.stop();
                }
            }
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Minimizes the window
            this.WindowState = FormWindowState.Minimized;
        }

        private void axWindowsMediaPlayer1_MouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e)
        {
        }
        //Unused code
        private void groupBox1_Paint_1(object sender, PaintEventArgs e)
        {
            Cursor.Show();
        }

        private void groupBox1_VisibleChanged(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void axWindowsMediaPlayer1_VisibleChanged(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void postimer_Tick(object sender, EventArgs e)
        {
            //Moves cursor to the corner of the screen
            Cursor.Position = new Point(1290, 1040);
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        /*private void button2_Click(object sender, EventArgs e)
        {
            launchGame(c + "\\Program Files\\TmUnitedForever\\TmForever.exe", c + "\\Program Files\\TmUnitedForever");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            launchGame(c + "\\Users\\Markus Maal\\AppData\\Roaming\\Roaming\\.minecraft\\TLauncher.exe", c + "\\Users\\Markus Maal\\AppData\\Roaming\\Roaming\\.minecraft");
        }*/

        public string launchGame(string fn, string wd)
        {
            //This function loads desired game
            //fn is filename and wd is working directory
            if (File.Exists(fn))
            {
                Process p = new Process();
                p.StartInfo.FileName = fn;
                p.StartInfo.WorkingDirectory = wd;
                p.Start();
                this.WindowState = FormWindowState.Minimized;
                return "success";
            }
            else
            {
                return "error";
            }
            return "error";
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Unloads media player to give permission to write to an existing file
            axWMP.Dispose();
            //Hides the form
            this.Hide();
            //Creates a new form and waits for it to close
            Form1 newform = new Form1();
            newform.ShowDialog();
            //Closes hidden form
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn26_Click(object sender, EventArgs e)
        {
            clickstate = 26;
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            clickstate = 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            clickstate = 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            clickstate = 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            clickstate = 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            clickstate = 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            clickstate = 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            clickstate = 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            clickstate = 8;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clickstate != 0)
            {
                GameList.SelectedIndex = clickstate;
                clickstate = 0;
                string stt = GameList.SelectedItem.ToString();
                stt = stt.Substring(0, stt.Length - 1);
                string wd = stt.Substring(0, stt.LastIndexOf("\\"));
                if (dev == true) { MessageBox.Show('"' + stt + '"'); }
                ProcessStartInfo _processStartInfo = new ProcessStartInfo();
                _processStartInfo.FileName = '"'.ToString() + stt + '"'.ToString();
                //must be false or working directory cannot be changed
                _processStartInfo.UseShellExecute = false;
                _processStartInfo.WorkingDirectory = wd;
                Process prc = Process.Start(_processStartInfo);
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            clickstate = 9;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            clickstate = 10;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            clickstate = 11;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            clickstate = 12;
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            clickstate = 13;
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            clickstate = 14;
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            clickstate = 15;
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            clickstate = 16;
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            clickstate = 17;
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            clickstate = 18;
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            clickstate = 19;
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            clickstate = 20;
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            clickstate = 21;
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            clickstate = 22;
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            clickstate = 23;
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            clickstate = 24;
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            clickstate = 25;
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            clickstate = 27;
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            clickstate = 28;
        }

        private void btn29_Click(object sender, EventArgs e)
        {
            clickstate = 29;
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            clickstate = 30;
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            clickstate = 31;
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            clickstate = 32;
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            clickstate = 33;
        }

        private void btn34_Click(object sender, EventArgs e)
        {
            clickstate = 34;
        }

        private void btn35_Click(object sender, EventArgs e)
        {
            clickstate = 35;
        }

        private void btn36_Click(object sender, EventArgs e)
        {
            clickstate = 36;
        }

    }

}
