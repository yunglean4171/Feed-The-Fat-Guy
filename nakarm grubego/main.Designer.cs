namespace nakarm_grubego
{
    partial class main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.burger = new System.Windows.Forms.PictureBox();
            this.xuiJoyStick1 = new XanderUI.XUIJoyStick();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.punkty = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ryj = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.display = new System.Windows.Forms.TextBox();
            this.tm = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.burger)).BeginInit();
            this.xuiGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ryj)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // burger
            // 
            this.burger.BackColor = System.Drawing.Color.Transparent;
            this.burger.Image = ((System.Drawing.Image)(resources.GetObject("burger.Image")));
            this.burger.Location = new System.Drawing.Point(568, 326);
            this.burger.Name = "burger";
            this.burger.Size = new System.Drawing.Size(74, 73);
            this.burger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.burger.TabIndex = 0;
            this.burger.TabStop = false;
            // 
            // xuiJoyStick1
            // 
            this.xuiJoyStick1.BackColor = System.Drawing.Color.White;
            this.xuiJoyStick1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xuiJoyStick1.BackgroundImage")));
            this.xuiJoyStick1.JoyStickColor = System.Drawing.Color.Indigo;
            this.xuiJoyStick1.KeepOnScreen = true;
            this.xuiJoyStick1.Location = new System.Drawing.Point(988, 549);
            this.xuiJoyStick1.MovableObject = this.burger;
            this.xuiJoyStick1.Name = "xuiJoyStick1";
            this.xuiJoyStick1.Sensitivity = 3;
            this.xuiJoyStick1.Size = new System.Drawing.Size(122, 122);
            this.xuiJoyStick1.TabIndex = 1;
            this.xuiJoyStick1.Text = "xuiJoyStick1";
            this.xuiJoyStick1.Click += new System.EventHandler(this.xuiJoyStick1_Click);
            this.xuiJoyStick1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.xuiJoyStick1_MouseClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.xuiJoyStick1;
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.RoyalBlue;
            this.xuiGradientPanel1.Controls.Add(this.punkty);
            this.xuiGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.xuiGradientPanel1.Location = new System.Drawing.Point(12, 38);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.MediumTurquoise;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(142, 58);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 2;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Blue;
            // 
            // punkty
            // 
            this.punkty.AutoSize = true;
            this.punkty.BackColor = System.Drawing.Color.Transparent;
            this.punkty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.punkty.ForeColor = System.Drawing.Color.Lime;
            this.punkty.Location = new System.Drawing.Point(77, 18);
            this.punkty.Name = "punkty";
            this.punkty.Size = new System.Drawing.Size(19, 20);
            this.punkty.TabIndex = 1;
            this.punkty.Text = "0";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 18);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(68, 20);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Punkty:";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.xuiGradientPanel1;
            // 
            // ryj
            // 
            this.ryj.BackColor = System.Drawing.Color.Transparent;
            this.ryj.Location = new System.Drawing.Point(66, 417);
            this.ryj.Name = "ryj";
            this.ryj.Size = new System.Drawing.Size(58, 29);
            this.ryj.TabIndex = 3;
            this.ryj.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-6, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 38);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(1044, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1084, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.display.Location = new System.Drawing.Point(12, 621);
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(169, 50);
            this.display.TabIndex = 5;
            this.display.Text = "00:00:00";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1124, 683);
            this.Controls.Add(this.display);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ryj);
            this.Controls.Add(this.xuiGradientPanel1);
            this.Controls.Add(this.xuiJoyStick1);
            this.Controls.Add(this.burger);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Nakarm grubasa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.burger)).EndInit();
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ryj)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox burger;
        private XanderUI.XUIJoyStick xuiJoyStick1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel punkty;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.PictureBox ryj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Timer tm;
    }
}

