namespace MarkuStation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.closebutton = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.gamegroup = new System.Windows.Forms.GroupBox();
            this.btn36 = new System.Windows.Forms.Button();
            this.btn34 = new System.Windows.Forms.Button();
            this.btn35 = new System.Windows.Forms.Button();
            this.btn33 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.btn28 = new System.Windows.Forms.Button();
            this.btn29 = new System.Windows.Forms.Button();
            this.btn27 = new System.Windows.Forms.Button();
            this.btn26 = new System.Windows.Forms.Button();
            this.btn25 = new System.Windows.Forms.Button();
            this.btn24 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn19 = new System.Windows.Forms.Button();
            this.btn18 = new System.Windows.Forms.Button();
            this.btn16 = new System.Windows.Forms.Button();
            this.btn17 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.llabel = new System.Windows.Forms.Label();
            this.minButton = new System.Windows.Forms.Button();
            this.mme = new System.Windows.Forms.Label();
            this.ms = new System.Windows.Forms.Label();
            this.letterM = new System.Windows.Forms.Label();
            this.letterS = new System.Windows.Forms.PictureBox();
            this.postimer = new System.Windows.Forms.Timer(this.components);
            this.startuplabel = new System.Windows.Forms.Label();
            this.rebutton = new System.Windows.Forms.Button();
            this.GameList = new System.Windows.Forms.ListBox();
            this.backgroundLoop = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            this.gamegroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.letterS)).BeginInit();
            this.SuspendLayout();
            // 
            // axWMP
            // 
            this.axWMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(0, 0);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(1280, 1024);
            this.axWMP.TabIndex = 4;
            this.axWMP.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWMP.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.axWindowsMediaPlayer1_ClickEvent);
            this.axWMP.KeyDownEvent += new AxWMPLib._WMPOCXEvents_KeyDownEventHandler(this.axWindowsMediaPlayer1_KeyDownEvent);
            this.axWMP.KeyPressEvent += new AxWMPLib._WMPOCXEvents_KeyPressEventHandler(this.axWindowsMediaPlayer1_KeyPressEvent);
            this.axWMP.MouseMoveEvent += new AxWMPLib._WMPOCXEvents_MouseMoveEventHandler(this.axWindowsMediaPlayer1_MouseMoveEvent);
            this.axWMP.VisibleChanged += new System.EventHandler(this.axWindowsMediaPlayer1_VisibleChanged);
            this.axWMP.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.DarkRed;
            this.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebutton.Location = new System.Drawing.Point(1242, 12);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(26, 23);
            this.closebutton.TabIndex = 5;
            this.closebutton.Text = "X";
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Visible = false;
            this.closebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn1.Image = global::MarkuStation.Properties.Resources.s;
            this.btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1.Location = new System.Drawing.Point(120, 31);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(313, 48);
            this.btn1.TabIndex = 6;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Visible = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
            // 
            // gamegroup
            // 
            this.gamegroup.BackColor = System.Drawing.Color.Black;
            this.gamegroup.Controls.Add(this.btn36);
            this.gamegroup.Controls.Add(this.btn34);
            this.gamegroup.Controls.Add(this.btn35);
            this.gamegroup.Controls.Add(this.btn33);
            this.gamegroup.Controls.Add(this.btn32);
            this.gamegroup.Controls.Add(this.btn31);
            this.gamegroup.Controls.Add(this.btn30);
            this.gamegroup.Controls.Add(this.btn28);
            this.gamegroup.Controls.Add(this.btn29);
            this.gamegroup.Controls.Add(this.btn27);
            this.gamegroup.Controls.Add(this.btn26);
            this.gamegroup.Controls.Add(this.btn25);
            this.gamegroup.Controls.Add(this.btn24);
            this.gamegroup.Controls.Add(this.btn22);
            this.gamegroup.Controls.Add(this.btn23);
            this.gamegroup.Controls.Add(this.btn21);
            this.gamegroup.Controls.Add(this.btn20);
            this.gamegroup.Controls.Add(this.btn19);
            this.gamegroup.Controls.Add(this.btn18);
            this.gamegroup.Controls.Add(this.btn16);
            this.gamegroup.Controls.Add(this.btn17);
            this.gamegroup.Controls.Add(this.btn15);
            this.gamegroup.Controls.Add(this.btn14);
            this.gamegroup.Controls.Add(this.btn13);
            this.gamegroup.Controls.Add(this.btn12);
            this.gamegroup.Controls.Add(this.btn10);
            this.gamegroup.Controls.Add(this.btn11);
            this.gamegroup.Controls.Add(this.btn9);
            this.gamegroup.Controls.Add(this.btn8);
            this.gamegroup.Controls.Add(this.btn7);
            this.gamegroup.Controls.Add(this.btn6);
            this.gamegroup.Controls.Add(this.btn4);
            this.gamegroup.Controls.Add(this.btn5);
            this.gamegroup.Controls.Add(this.btn3);
            this.gamegroup.Controls.Add(this.btn2);
            this.gamegroup.Controls.Add(this.btn1);
            this.gamegroup.Controls.Add(this.llabel);
            this.gamegroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gamegroup.ForeColor = System.Drawing.Color.White;
            this.gamegroup.Location = new System.Drawing.Point(29, 93);
            this.gamegroup.Name = "gamegroup";
            this.gamegroup.Size = new System.Drawing.Size(1222, 890);
            this.gamegroup.TabIndex = 7;
            this.gamegroup.TabStop = false;
            this.gamegroup.Text = "Mängud";
            this.gamegroup.Visible = false;
            this.gamegroup.VisibleChanged += new System.EventHandler(this.groupBox1_VisibleChanged);
            this.gamegroup.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint_1);
            // 
            // btn36
            // 
            this.btn36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn36.Image = global::MarkuStation.Properties.Resources.s;
            this.btn36.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn36.Location = new System.Drawing.Point(783, 625);
            this.btn36.Name = "btn36";
            this.btn36.Size = new System.Drawing.Size(313, 48);
            this.btn36.TabIndex = 44;
            this.btn36.UseVisualStyleBackColor = true;
            this.btn36.Click += new System.EventHandler(this.btn36_Click);
            // 
            // btn34
            // 
            this.btn34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn34.Image = global::MarkuStation.Properties.Resources.s;
            this.btn34.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn34.Location = new System.Drawing.Point(120, 625);
            this.btn34.Name = "btn34";
            this.btn34.Size = new System.Drawing.Size(313, 48);
            this.btn34.TabIndex = 43;
            this.btn34.UseVisualStyleBackColor = true;
            this.btn34.Click += new System.EventHandler(this.btn34_Click);
            // 
            // btn35
            // 
            this.btn35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn35.Image = global::MarkuStation.Properties.Resources.s;
            this.btn35.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn35.Location = new System.Drawing.Point(453, 625);
            this.btn35.Name = "btn35";
            this.btn35.Size = new System.Drawing.Size(313, 48);
            this.btn35.TabIndex = 42;
            this.btn35.UseVisualStyleBackColor = true;
            this.btn35.Click += new System.EventHandler(this.btn35_Click);
            // 
            // btn33
            // 
            this.btn33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn33.Image = global::MarkuStation.Properties.Resources.s;
            this.btn33.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn33.Location = new System.Drawing.Point(783, 571);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(313, 48);
            this.btn33.TabIndex = 41;
            this.btn33.UseVisualStyleBackColor = true;
            this.btn33.Click += new System.EventHandler(this.btn33_Click);
            // 
            // btn32
            // 
            this.btn32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn32.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn32.Image = global::MarkuStation.Properties.Resources.s;
            this.btn32.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn32.Location = new System.Drawing.Point(453, 571);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(313, 48);
            this.btn32.TabIndex = 40;
            this.btn32.UseVisualStyleBackColor = true;
            this.btn32.Click += new System.EventHandler(this.btn32_Click);
            // 
            // btn31
            // 
            this.btn31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn31.Image = global::MarkuStation.Properties.Resources.s;
            this.btn31.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn31.Location = new System.Drawing.Point(120, 571);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(313, 48);
            this.btn31.TabIndex = 39;
            this.btn31.UseVisualStyleBackColor = true;
            this.btn31.Click += new System.EventHandler(this.btn31_Click);
            // 
            // btn30
            // 
            this.btn30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn30.Image = global::MarkuStation.Properties.Resources.s;
            this.btn30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn30.Location = new System.Drawing.Point(783, 517);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(313, 48);
            this.btn30.TabIndex = 38;
            this.btn30.UseVisualStyleBackColor = true;
            this.btn30.Click += new System.EventHandler(this.btn30_Click);
            // 
            // btn28
            // 
            this.btn28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn28.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn28.Image = global::MarkuStation.Properties.Resources.s;
            this.btn28.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn28.Location = new System.Drawing.Point(120, 517);
            this.btn28.Name = "btn28";
            this.btn28.Size = new System.Drawing.Size(313, 48);
            this.btn28.TabIndex = 37;
            this.btn28.UseVisualStyleBackColor = true;
            this.btn28.Click += new System.EventHandler(this.btn28_Click);
            // 
            // btn29
            // 
            this.btn29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn29.Image = global::MarkuStation.Properties.Resources.s;
            this.btn29.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn29.Location = new System.Drawing.Point(453, 517);
            this.btn29.Name = "btn29";
            this.btn29.Size = new System.Drawing.Size(313, 48);
            this.btn29.TabIndex = 36;
            this.btn29.UseVisualStyleBackColor = true;
            this.btn29.Click += new System.EventHandler(this.btn29_Click);
            // 
            // btn27
            // 
            this.btn27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn27.Image = global::MarkuStation.Properties.Resources.s;
            this.btn27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn27.Location = new System.Drawing.Point(783, 463);
            this.btn27.Name = "btn27";
            this.btn27.Size = new System.Drawing.Size(313, 48);
            this.btn27.TabIndex = 35;
            this.btn27.UseVisualStyleBackColor = true;
            this.btn27.Click += new System.EventHandler(this.btn27_Click);
            // 
            // btn26
            // 
            this.btn26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn26.Image = global::MarkuStation.Properties.Resources.s;
            this.btn26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn26.Location = new System.Drawing.Point(453, 463);
            this.btn26.Name = "btn26";
            this.btn26.Size = new System.Drawing.Size(313, 48);
            this.btn26.TabIndex = 34;
            this.btn26.UseVisualStyleBackColor = true;
            this.btn26.Click += new System.EventHandler(this.btn26_Click);
            // 
            // btn25
            // 
            this.btn25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn25.Image = global::MarkuStation.Properties.Resources.s;
            this.btn25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn25.Location = new System.Drawing.Point(120, 463);
            this.btn25.Name = "btn25";
            this.btn25.Size = new System.Drawing.Size(313, 48);
            this.btn25.TabIndex = 33;
            this.btn25.UseVisualStyleBackColor = true;
            this.btn25.Click += new System.EventHandler(this.btn25_Click);
            // 
            // btn24
            // 
            this.btn24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn24.Image = global::MarkuStation.Properties.Resources.s;
            this.btn24.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn24.Location = new System.Drawing.Point(783, 409);
            this.btn24.Name = "btn24";
            this.btn24.Size = new System.Drawing.Size(313, 48);
            this.btn24.TabIndex = 32;
            this.btn24.UseVisualStyleBackColor = true;
            this.btn24.Click += new System.EventHandler(this.btn24_Click);
            // 
            // btn22
            // 
            this.btn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn22.Image = global::MarkuStation.Properties.Resources.s;
            this.btn22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn22.Location = new System.Drawing.Point(120, 409);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(313, 48);
            this.btn22.TabIndex = 31;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Click += new System.EventHandler(this.btn22_Click);
            // 
            // btn23
            // 
            this.btn23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn23.Image = global::MarkuStation.Properties.Resources.s;
            this.btn23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn23.Location = new System.Drawing.Point(453, 409);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(313, 48);
            this.btn23.TabIndex = 30;
            this.btn23.UseVisualStyleBackColor = true;
            this.btn23.Click += new System.EventHandler(this.btn23_Click);
            // 
            // btn21
            // 
            this.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn21.Image = global::MarkuStation.Properties.Resources.s;
            this.btn21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn21.Location = new System.Drawing.Point(783, 355);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(313, 48);
            this.btn21.TabIndex = 29;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.btn21_Click);
            // 
            // btn20
            // 
            this.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn20.Image = global::MarkuStation.Properties.Resources.s;
            this.btn20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn20.Location = new System.Drawing.Point(453, 355);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(313, 48);
            this.btn20.TabIndex = 28;
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // btn19
            // 
            this.btn19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn19.Image = global::MarkuStation.Properties.Resources.s;
            this.btn19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn19.Location = new System.Drawing.Point(120, 355);
            this.btn19.Name = "btn19";
            this.btn19.Size = new System.Drawing.Size(313, 48);
            this.btn19.TabIndex = 27;
            this.btn19.UseVisualStyleBackColor = true;
            this.btn19.Click += new System.EventHandler(this.btn19_Click);
            // 
            // btn18
            // 
            this.btn18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn18.Image = global::MarkuStation.Properties.Resources.s;
            this.btn18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn18.Location = new System.Drawing.Point(783, 301);
            this.btn18.Name = "btn18";
            this.btn18.Size = new System.Drawing.Size(313, 48);
            this.btn18.TabIndex = 26;
            this.btn18.UseVisualStyleBackColor = true;
            this.btn18.Click += new System.EventHandler(this.btn18_Click);
            // 
            // btn16
            // 
            this.btn16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn16.Image = global::MarkuStation.Properties.Resources.s;
            this.btn16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn16.Location = new System.Drawing.Point(120, 301);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(313, 48);
            this.btn16.TabIndex = 25;
            this.btn16.UseVisualStyleBackColor = true;
            this.btn16.Click += new System.EventHandler(this.btn16_Click);
            // 
            // btn17
            // 
            this.btn17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn17.Image = global::MarkuStation.Properties.Resources.s;
            this.btn17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn17.Location = new System.Drawing.Point(453, 301);
            this.btn17.Name = "btn17";
            this.btn17.Size = new System.Drawing.Size(313, 48);
            this.btn17.TabIndex = 24;
            this.btn17.UseVisualStyleBackColor = true;
            this.btn17.Click += new System.EventHandler(this.btn17_Click);
            // 
            // btn15
            // 
            this.btn15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn15.Image = global::MarkuStation.Properties.Resources.s;
            this.btn15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn15.Location = new System.Drawing.Point(783, 247);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(313, 48);
            this.btn15.TabIndex = 23;
            this.btn15.UseVisualStyleBackColor = true;
            this.btn15.Click += new System.EventHandler(this.btn15_Click);
            // 
            // btn14
            // 
            this.btn14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn14.Image = global::MarkuStation.Properties.Resources.s;
            this.btn14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn14.Location = new System.Drawing.Point(453, 247);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(313, 48);
            this.btn14.TabIndex = 22;
            this.btn14.UseVisualStyleBackColor = true;
            this.btn14.Click += new System.EventHandler(this.btn14_Click);
            // 
            // btn13
            // 
            this.btn13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn13.Image = global::MarkuStation.Properties.Resources.s;
            this.btn13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn13.Location = new System.Drawing.Point(120, 247);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(313, 48);
            this.btn13.TabIndex = 21;
            this.btn13.UseVisualStyleBackColor = true;
            this.btn13.Click += new System.EventHandler(this.btn13_Click);
            // 
            // btn12
            // 
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn12.Image = global::MarkuStation.Properties.Resources.s;
            this.btn12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn12.Location = new System.Drawing.Point(783, 193);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(313, 48);
            this.btn12.TabIndex = 20;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btn12_Click);
            // 
            // btn10
            // 
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn10.Image = global::MarkuStation.Properties.Resources.s;
            this.btn10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn10.Location = new System.Drawing.Point(120, 193);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(313, 48);
            this.btn10.TabIndex = 19;
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn11
            // 
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn11.Image = global::MarkuStation.Properties.Resources.s;
            this.btn11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn11.Location = new System.Drawing.Point(453, 193);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(313, 48);
            this.btn11.TabIndex = 18;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.btn11_Click);
            // 
            // btn9
            // 
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn9.Image = global::MarkuStation.Properties.Resources.s;
            this.btn9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn9.Location = new System.Drawing.Point(783, 139);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(313, 48);
            this.btn9.TabIndex = 17;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn8.Image = global::MarkuStation.Properties.Resources.s;
            this.btn8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn8.Location = new System.Drawing.Point(453, 139);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(313, 48);
            this.btn8.TabIndex = 16;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn7.Image = global::MarkuStation.Properties.Resources.s;
            this.btn7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn7.Location = new System.Drawing.Point(120, 139);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(313, 48);
            this.btn7.TabIndex = 15;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn6.Image = global::MarkuStation.Properties.Resources.s;
            this.btn6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn6.Location = new System.Drawing.Point(783, 85);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(313, 48);
            this.btn6.TabIndex = 11;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn4.Image = global::MarkuStation.Properties.Resources.s;
            this.btn4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn4.Location = new System.Drawing.Point(120, 85);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(313, 48);
            this.btn4.TabIndex = 10;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn5.Image = global::MarkuStation.Properties.Resources.s;
            this.btn5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn5.Location = new System.Drawing.Point(453, 85);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(313, 48);
            this.btn5.TabIndex = 9;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn3.Image = global::MarkuStation.Properties.Resources.s;
            this.btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3.Location = new System.Drawing.Point(783, 31);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(313, 48);
            this.btn3.TabIndex = 8;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn2.Image = global::MarkuStation.Properties.Resources.s;
            this.btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2.Location = new System.Drawing.Point(453, 31);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(313, 48);
            this.btn2.TabIndex = 7;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // llabel
            // 
            this.llabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llabel.Location = new System.Drawing.Point(-29, -93);
            this.llabel.Name = "llabel";
            this.llabel.Size = new System.Drawing.Size(1280, 1024);
            this.llabel.TabIndex = 14;
            this.llabel.Text = "label5";
            this.llabel.Click += new System.EventHandler(this.btn1_Click);
            // 
            // minButton
            // 
            this.minButton.BackColor = System.Drawing.Color.DarkBlue;
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.Location = new System.Drawing.Point(1210, 12);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(26, 23);
            this.minButton.TabIndex = 8;
            this.minButton.Text = "_";
            this.minButton.UseVisualStyleBackColor = false;
            this.minButton.Visible = false;
            this.minButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // mme
            // 
            this.mme.AutoSize = true;
            this.mme.Font = new System.Drawing.Font("Calibri", 10F);
            this.mme.Location = new System.Drawing.Point(83, 56);
            this.mme.Name = "mme";
            this.mme.Size = new System.Drawing.Size(166, 17);
            this.mme.TabIndex = 12;
            this.mme.Text = "Markuse meelelahutus Eesti";
            this.mme.Visible = false;
            // 
            // ms
            // 
            this.ms.AutoSize = true;
            this.ms.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.ms.Location = new System.Drawing.Point(77, 23);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(169, 33);
            this.ms.TabIndex = 11;
            this.ms.Text = "MarkuStation";
            this.ms.Visible = false;
            // 
            // letterM
            // 
            this.letterM.Font = new System.Drawing.Font("Calibri", 30F);
            this.letterM.ForeColor = System.Drawing.Color.Chartreuse;
            this.letterM.Location = new System.Drawing.Point(21, 11);
            this.letterM.Name = "letterM";
            this.letterM.Size = new System.Drawing.Size(34, 38);
            this.letterM.TabIndex = 9;
            this.letterM.Text = "M";
            this.letterM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.letterM.Visible = false;
            // 
            // letterS
            // 
            this.letterS.BackgroundImage = global::MarkuStation.Properties.Resources.s;
            this.letterS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.letterS.Location = new System.Drawing.Point(39, 43);
            this.letterS.Name = "letterS";
            this.letterS.Size = new System.Drawing.Size(37, 38);
            this.letterS.TabIndex = 10;
            this.letterS.TabStop = false;
            this.letterS.Visible = false;
            // 
            // postimer
            // 
            this.postimer.Enabled = true;
            this.postimer.Interval = 1;
            this.postimer.Tick += new System.EventHandler(this.postimer_Tick);
            // 
            // startuplabel
            // 
            this.startuplabel.BackColor = System.Drawing.Color.Transparent;
            this.startuplabel.Font = new System.Drawing.Font("Arial", 18F);
            this.startuplabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.startuplabel.Location = new System.Drawing.Point(12, 9);
            this.startuplabel.Name = "startuplabel";
            this.startuplabel.Size = new System.Drawing.Size(1256, 31);
            this.startuplabel.TabIndex = 13;
            this.startuplabel.Text = "Starting unknown console...";
            // 
            // rebutton
            // 
            this.rebutton.BackColor = System.Drawing.Color.Green;
            this.rebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rebutton.Location = new System.Drawing.Point(1178, 12);
            this.rebutton.Name = "rebutton";
            this.rebutton.Size = new System.Drawing.Size(26, 23);
            this.rebutton.TabIndex = 14;
            this.rebutton.Text = "R";
            this.rebutton.UseVisualStyleBackColor = false;
            this.rebutton.Visible = false;
            this.rebutton.Click += new System.EventHandler(this.button9_Click);
            // 
            // GameList
            // 
            this.GameList.FormattingEnabled = true;
            this.GameList.Location = new System.Drawing.Point(482, 12);
            this.GameList.Name = "GameList";
            this.GameList.Size = new System.Drawing.Size(120, 95);
            this.GameList.TabIndex = 15;
            this.GameList.Visible = false;
            // 
            // backgroundLoop
            // 
            this.backgroundLoop.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Controls.Add(this.GameList);
            this.Controls.Add(this.startuplabel);
            this.Controls.Add(this.rebutton);
            this.Controls.Add(this.mme);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.letterM);
            this.Controls.Add(this.letterS);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.gamegroup);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.axWMP);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.gamegroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.letterS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.GroupBox gamegroup;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Label mme;
        private System.Windows.Forms.Label ms;
        private System.Windows.Forms.Label letterM;
        private System.Windows.Forms.PictureBox letterS;
        private System.Windows.Forms.Timer postimer;
        private System.Windows.Forms.Label startuplabel;
        private System.Windows.Forms.Label llabel;
        private System.Windows.Forms.Button rebutton;
        private System.Windows.Forms.Button btn36;
        private System.Windows.Forms.Button btn34;
        private System.Windows.Forms.Button btn35;
        private System.Windows.Forms.Button btn33;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Button btn28;
        private System.Windows.Forms.Button btn29;
        private System.Windows.Forms.Button btn27;
        private System.Windows.Forms.Button btn26;
        private System.Windows.Forms.Button btn25;
        private System.Windows.Forms.Button btn24;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn19;
        private System.Windows.Forms.Button btn18;
        private System.Windows.Forms.Button btn16;
        private System.Windows.Forms.Button btn17;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.ListBox GameList;
        private System.Windows.Forms.Timer backgroundLoop;
    }

    
}

