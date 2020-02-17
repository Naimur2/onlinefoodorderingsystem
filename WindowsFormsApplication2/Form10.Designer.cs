namespace WindowsFormsApplication2
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mname = new System.Windows.Forms.TextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.sname = new System.Windows.Forms.TextBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.mmail = new System.Windows.Forms.TextBox();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.mphone = new System.Windows.Forms.TextBox();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.maddress = new System.Windows.Forms.TextBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuButton3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mname
            // 
            this.mname.BackColor = System.Drawing.SystemColors.Window;
            this.mname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mname.Enabled = false;
            this.mname.Location = new System.Drawing.Point(103, 239);
            this.mname.MaxLength = 30;
            this.mname.Multiline = true;
            this.mname.Name = "mname";
            this.mname.ReadOnly = true;
            this.mname.Size = new System.Drawing.Size(311, 32);
            this.mname.TabIndex = 92;
            this.mname.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(50, 244);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(47, 19);
            this.bunifuLabel1.TabIndex = 91;
            this.bunifuLabel1.Text = "Name:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // sname
            // 
            this.sname.BackColor = System.Drawing.SystemColors.Window;
            this.sname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sname.Enabled = false;
            this.sname.Location = new System.Drawing.Point(103, 289);
            this.sname.MaxLength = 30;
            this.sname.Multiline = true;
            this.sname.Name = "sname";
            this.sname.ReadOnly = true;
            this.sname.Size = new System.Drawing.Size(311, 32);
            this.sname.TabIndex = 94;
            this.sname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(28, 295);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(69, 19);
            this.bunifuLabel2.TabIndex = 93;
            this.bunifuLabel2.Text = "Shopame:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel2.Click += new System.EventHandler(this.bunifuLabel2_Click);
            // 
            // mmail
            // 
            this.mmail.BackColor = System.Drawing.SystemColors.Window;
            this.mmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mmail.Enabled = false;
            this.mmail.Location = new System.Drawing.Point(103, 339);
            this.mmail.MaxLength = 30;
            this.mmail.Multiline = true;
            this.mmail.Name = "mmail";
            this.mmail.ReadOnly = true;
            this.mmail.Size = new System.Drawing.Size(311, 32);
            this.mmail.TabIndex = 98;
            this.mmail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.Location = new System.Drawing.Point(52, 347);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(42, 19);
            this.bunifuLabel4.TabIndex = 97;
            this.bunifuLabel4.Text = "Email:";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel4.Click += new System.EventHandler(this.bunifuLabel4_Click);
            // 
            // mphone
            // 
            this.mphone.BackColor = System.Drawing.SystemColors.Window;
            this.mphone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mphone.Enabled = false;
            this.mphone.Location = new System.Drawing.Point(103, 389);
            this.mphone.MaxLength = 30;
            this.mphone.Multiline = true;
            this.mphone.Name = "mphone";
            this.mphone.ReadOnly = true;
            this.mphone.Size = new System.Drawing.Size(311, 32);
            this.mphone.TabIndex = 100;
            this.mphone.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.Location = new System.Drawing.Point(49, 397);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(48, 19);
            this.bunifuLabel5.TabIndex = 99;
            this.bunifuLabel5.Text = "Phone:";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel5.Click += new System.EventHandler(this.bunifuLabel5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 102;
            this.label1.Text = "Manager details  FOR ADMIN";
            this.label1.Visible = false;
            // 
            // maddress
            // 
            this.maddress.BackColor = System.Drawing.SystemColors.Window;
            this.maddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maddress.Enabled = false;
            this.maddress.Location = new System.Drawing.Point(103, 439);
            this.maddress.MaxLength = 30;
            this.maddress.Multiline = true;
            this.maddress.Name = "maddress";
            this.maddress.ReadOnly = true;
            this.maddress.Size = new System.Drawing.Size(311, 48);
            this.maddress.TabIndex = 105;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(41, 453);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(56, 19);
            this.bunifuLabel3.TabIndex = 104;
            this.bunifuLabel3.Text = "Address:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 72;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(175, 50);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(145, 145);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 106;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 557);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 77);
            this.panel1.TabIndex = 110;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bunifuPictureBox1);
            this.panel2.Controls.Add(this.maddress);
            this.panel2.Controls.Add(this.bunifuLabel3);
            this.panel2.Controls.Add(this.bunifuLabel1);
            this.panel2.Controls.Add(this.mphone);
            this.panel2.Controls.Add(this.mname);
            this.panel2.Controls.Add(this.bunifuLabel5);
            this.panel2.Controls.Add(this.bunifuLabel2);
            this.panel2.Controls.Add(this.mmail);
            this.panel2.Controls.Add(this.sname);
            this.panel2.Controls.Add(this.bunifuLabel4);
            this.panel2.Location = new System.Drawing.Point(53, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 561);
            this.panel2.TabIndex = 111;
            // 
            // bunifuButton3
            // 
            this.bunifuButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton3.BackgroundImage")));
            this.bunifuButton3.ButtonText = "Add Manager";
            this.bunifuButton3.ButtonTextMarginLeft = 0;
            this.bunifuButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton3.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton3.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton3.IconPadding = 10;
            this.bunifuButton3.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton3.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton3.IdleBorderRadius = 1;
            this.bunifuButton3.IdleBorderThickness = 0;
            this.bunifuButton3.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton3.IdleIconLeftImage = null;
            this.bunifuButton3.IdleIconRightImage = null;
            this.bunifuButton3.Location = new System.Drawing.Point(104, 439);
            this.bunifuButton3.Name = "bunifuButton3";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bunifuButton3.onHoverState = stateProperties1;
            this.bunifuButton3.Size = new System.Drawing.Size(311, 45);
            this.bunifuButton3.TabIndex = 110;
            this.bunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton3.Click += new System.EventHandler(this.bunifuButton3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.bunifuLabel7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.bunifuButton1);
            this.panel3.Controls.Add(this.bunifuButton3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.bunifuPictureBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.bunifuLabel6);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.bunifuLabel8);
            this.panel3.Location = new System.Drawing.Point(573, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 561);
            this.panel3.TabIndex = 112;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 17);
            this.label2.TabIndex = 102;
            this.label2.Text = "Manager details  FOR ADMIN";
            this.label2.Visible = false;
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.BorderRadius = 72;
            this.bunifuPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox2.Image")));
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(163, 74);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(145, 145);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 106;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(104, 339);
            this.textBox1.MaxLength = 30;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(311, 48);
            this.textBox1.TabIndex = 105;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel6.Location = new System.Drawing.Point(30, 352);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(68, 19);
            this.bunifuLabel6.TabIndex = 104;
            this.bunifuLabel6.Text = "Password:";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(104, 244);
            this.textBox2.MaxLength = 30;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(311, 32);
            this.textBox2.TabIndex = 100;
            // 
            // bunifuLabel8
            // 
            this.bunifuLabel8.AutoEllipsis = false;
            this.bunifuLabel8.CursorType = null;
            this.bunifuLabel8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel8.Location = new System.Drawing.Point(32, 250);
            this.bunifuLabel8.Name = "bunifuLabel8";
            this.bunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel8.Size = new System.Drawing.Size(66, 19);
            this.bunifuLabel8.TabIndex = 99;
            this.bunifuLabel8.Text = "Username ";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.ButtonText = "Clear Manger Information ";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.Location = new System.Drawing.Point(104, 490);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties2;
            this.bunifuButton1.Size = new System.Drawing.Size(311, 45);
            this.bunifuButton1.TabIndex = 111;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 34);
            this.label3.TabIndex = 112;
            this.label3.Text = "You don\'t need to add @shop.as,\r\nSoftware will automatically add this";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(104, 289);
            this.textBox3.MaxLength = 30;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(311, 32);
            this.textBox3.TabIndex = 114;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.CursorType = null;
            this.bunifuLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel7.Location = new System.Drawing.Point(56, 295);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(42, 19);
            this.bunifuLabel7.TabIndex = 113;
            this.bunifuLabel7.Text = "Email:";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1132, 634);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox mname;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.TextBox sname;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.TextBox mmail;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private System.Windows.Forms.TextBox mphone;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maddress;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton3;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private System.Windows.Forms.TextBox textBox2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
    }
}