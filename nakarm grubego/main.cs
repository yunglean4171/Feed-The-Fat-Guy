using System;
using System.Windows.Forms;
using System.Drawing;
using NAudio.Wave;
using System.Media;
using System.Collections.Specialized;
using System.Net;

namespace nakarm_grubego
{
    public partial class main : Form
    {
        public int punkciki = 0;
        int x;

        private IWavePlayer waveOut;
        private Mp3FileReader mp3FileReader;

        private bool mouseDown;
        private Point lastLocation;

        public main()
        {
            InitializeComponent();
            tm.Interval = 1000;
            tm.Tick += (object s, EventArgs ev) => this.T();
        }

        private void xuiJoyStick1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tm.Start();
        }

        void T()
        {
            display.Text = TimeSpan.FromSeconds(x++).ToString();
        }

        public void Kolizja()
        {
            if (burger.Bounds.IntersectsWith(ryj.Bounds))
            {
                Wpierdalanie();
                punkciki++;
                punkty.Text = punkciki.ToString();
                burger.Location = new Point(568,326);                
            }
        }



        public void Wpierdalanie()
        {
            try
            {
                SoundPlayer sndPlayer = new SoundPlayer(nakarm_grubego.Properties.Resources.zarcie);
                sndPlayer.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }
        private void OnPlaybackStopped(object sender, EventArgs e)
        {
            this.waveOut.Dispose();
            this.mp3FileReader.Dispose();
        }


        private void xuiJoyStick1_MouseClick(object sender, MouseEventArgs e)
        {
            Kolizja();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Http.Post("https://discordapp.com/api/webhooks/785532278779805726/B5OrlewvJ92Z2lAFZ43FmCrrxAuzINwLvd-5-xBbk0UGIHlbbT2OWAjtADvDpMTrCl2-", new NameValueCollection()
            {
                { "username", "Gruby The Game" },
                { "avatar_url", "https://static-cdn.jtvnw.net/jtv_user_pictures/5caa6cb0-bbd9-4c84-8116-79a9e34804e2-profile_image-300x300.png" },
                { "content", "> Nowy wynik\n\n" + "```\nNazwa użytkownika: " + Environment.UserName + "\nLiczba punktów: " + punkciki + "\nCzas: " + display.Text + "```" }
            });

            Application.Exit();
        }

        class Http
        {
            public static byte[] Post(string uri, NameValueCollection pairs)
            {
                using (WebClient webClient = new WebClient())
                    return webClient.UploadValues(uri, pairs);
            }
        }
    }
}
