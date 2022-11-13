namespace calculater
{
    partial class convertor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(convertor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uNITConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uNITConverterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calculaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctext = new System.Windows.Forms.TextBox();
            this.ftext = new System.Windows.Forms.TextBox();
            this.ktext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uNITConverterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uNITConverterToolStripMenuItem
            // 
            this.uNITConverterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uNITConverterToolStripMenuItem1,
            this.calculaterToolStripMenuItem});
            this.uNITConverterToolStripMenuItem.Name = "uNITConverterToolStripMenuItem";
            this.uNITConverterToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.uNITConverterToolStripMenuItem.Text = "Menu";
            this.uNITConverterToolStripMenuItem.Click += new System.EventHandler(this.uNITConverterToolStripMenuItem_Click);
            // 
            // uNITConverterToolStripMenuItem1
            // 
            this.uNITConverterToolStripMenuItem1.Name = "uNITConverterToolStripMenuItem1";
            this.uNITConverterToolStripMenuItem1.Size = new System.Drawing.Size(193, 26);
            this.uNITConverterToolStripMenuItem1.Text = "UNIT Converter";
            this.uNITConverterToolStripMenuItem1.Click += new System.EventHandler(this.uNITConverterToolStripMenuItem1_Click);
            // 
            // calculaterToolStripMenuItem
            // 
            this.calculaterToolStripMenuItem.Name = "calculaterToolStripMenuItem";
            this.calculaterToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.calculaterToolStripMenuItem.Text = "Calculater";
            this.calculaterToolStripMenuItem.Click += new System.EventHandler(this.calculaterToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Celsius (C\')";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kelvin (K)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fahrenheit (F\')";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ctext
            // 
            this.ctext.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ctext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctext.Location = new System.Drawing.Point(380, 82);
            this.ctext.Multiline = true;
            this.ctext.Name = "ctext";
            this.ctext.Size = new System.Drawing.Size(300, 50);
            this.ctext.TabIndex = 4;
            // 
            // ftext
            // 
            this.ftext.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ftext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ftext.Location = new System.Drawing.Point(380, 181);
            this.ftext.Multiline = true;
            this.ftext.Name = "ftext";
            this.ftext.Size = new System.Drawing.Size(300, 50);
            this.ftext.TabIndex = 5;
            // 
            // ktext
            // 
            this.ktext.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ktext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ktext.Location = new System.Drawing.Point(380, 271);
            this.ktext.Multiline = true;
            this.ktext.Name = "ktext";
            this.ktext.Size = new System.Drawing.Size(300, 50);
            this.ktext.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(143, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "convert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.convert_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(402, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // convertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(702, 403);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ktext);
            this.Controls.Add(this.ftext);
            this.Controls.Add(this.ctext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "convertor";
            this.Text = " Temperature converter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.convertor_FormClosed);
            this.Load += new System.EventHandler(this.convertor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem uNITConverterToolStripMenuItem;
        private ToolStripMenuItem uNITConverterToolStripMenuItem1;
        private ToolStripMenuItem calculaterToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox ctext;
        private TextBox ftext;
        private TextBox ktext;
        private Button button1;
        private Button button2;
    }
}