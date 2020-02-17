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
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
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
            this.mname.Location = new System.Drawing.Point(403, 232);
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
            this.bunifuLabel1.Location = new System.Drawing.Point(350, 237);
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
            this.sname.Location = new System.Drawing.Point(403, 282);
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
            this.bunifuLabel2.Location = new System.Drawing.Point(328, 288);
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
            this.mmail.Location = new System.Drawing.Point(403, 332);
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
            this.bunifuLabel4.Location = new System.Drawing.Point(352, 340);
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
            this.mphone.Location = new System.Drawing.Point(403, 382);
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
            this.bunifuLabel5.Location = new System.Drawing.Point(349, 390);
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
            this.label1.Location = new System.Drawing.Point(732, 9);
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
            this.maddress.Location = new System.Drawing.Point(403, 432);
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
            this.bunifuLabel3.Location = new System.Drawing.Point(341, 446);
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
            this.bunifuPictureBox1.Location = new System.Drawing.Point(474, 9);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(145, 145);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 106;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1132, 634);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.maddress);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mphone);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.mmail);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.mname);
            this.Controls.Add(this.bunifuLabel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}