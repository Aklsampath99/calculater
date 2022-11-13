namespace calculater
{
    partial class unit_convertor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(unit_convertor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.value_enter_text_box = new System.Windows.Forms.TextBox();
            this.ansertextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.ListBox();
            this.to = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculaterToolStripMenuItem,
            this.temperatureConverterToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.fileToolStripMenuItem.Text = "Menu";
            // 
            // calculaterToolStripMenuItem
            // 
            this.calculaterToolStripMenuItem.Name = "calculaterToolStripMenuItem";
            this.calculaterToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.calculaterToolStripMenuItem.Text = "Calculater";
            this.calculaterToolStripMenuItem.Click += new System.EventHandler(this.calculaterToolStripMenuItem_Click);
            // 
            // temperatureConverterToolStripMenuItem
            // 
            this.temperatureConverterToolStripMenuItem.Name = "temperatureConverterToolStripMenuItem";
            this.temperatureConverterToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.temperatureConverterToolStripMenuItem.Text = "Temperature converter";
            this.temperatureConverterToolStripMenuItem.Click += new System.EventHandler(this.temperatureConverterToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(255, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "convert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(105, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "UNIT CONVERTER";
            // 
            // value_enter_text_box
            // 
            this.value_enter_text_box.Location = new System.Drawing.Point(267, 116);
            this.value_enter_text_box.Multiline = true;
            this.value_enter_text_box.Name = "value_enter_text_box";
            this.value_enter_text_box.Size = new System.Drawing.Size(323, 53);
            this.value_enter_text_box.TabIndex = 3;
            // 
            // ansertextbox
            // 
            this.ansertextbox.Location = new System.Drawing.Point(267, 186);
            this.ansertextbox.Multiline = true;
            this.ansertextbox.Name = "ansertextbox";
            this.ansertextbox.Size = new System.Drawing.Size(323, 53);
            this.ansertextbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swis721 BlkCn BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(22, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(22, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "covert From :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(436, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "covert To :";
            // 
            // from
            // 
            this.from.BackColor = System.Drawing.Color.Black;
            this.from.Font = new System.Drawing.Font("SansSerif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.from.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.from.FormattingEnabled = true;
            this.from.ItemHeight = 20;
            this.from.Items.AddRange(new object[] {
            "Meter (m)",
            "Centimeter (cm)",
            "Kilometer (Km)",
            "gram (g)",
            "Kilogram (Kg)"});
            this.from.Location = new System.Drawing.Point(22, 307);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(154, 104);
            this.from.TabIndex = 8;
            // 
            // to
            // 
            this.to.BackColor = System.Drawing.Color.Black;
            this.to.Font = new System.Drawing.Font("SansSerif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.to.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.to.FormattingEnabled = true;
            this.to.ItemHeight = 20;
            this.to.Items.AddRange(new object[] {
            "Meter (m)",
            "Centimeter (cm)",
            "Kilometer (Km)",
            "gram (g)",
            "Kilogram (Kg)"});
            this.to.Location = new System.Drawing.Point(436, 307);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(154, 104);
            this.to.TabIndex = 9;
            // 
            // unit_convertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(656, 484);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ansertextbox);
            this.Controls.Add(this.value_enter_text_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "unit_convertor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit Convertor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem calculaterToolStripMenuItem;
        private ToolStripMenuItem temperatureConverterToolStripMenuItem;
        private Button button1;
        private Label label1;
        private TextBox value_enter_text_box;
        private TextBox ansertextbox;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox from;
        private ListBox to;
    }
}