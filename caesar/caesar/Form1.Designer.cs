namespace caesar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btmh = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbbr = new TextBox();
            num = new NumericUpDown();
            tbmh = new TextBox();
            btgm = new Button();
            label4 = new Label();
            tbgm = new TextBox();
            btrs = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            savemh = new ToolStripMenuItem();
            savegm = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)num).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btmh
            // 
            btmh.Font = new Font("Segoe UI", 14F);
            btmh.Location = new Point(193, 171);
            btmh.Name = "btmh";
            btmh.Size = new Size(115, 50);
            btmh.TabIndex = 0;
            btmh.Text = "Mã hoá";
            btmh.UseVisualStyleBackColor = true;
            btmh.Click += btmh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(119, 54);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 1;
            label1.Text = "Đầu vào:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(119, 126);
            label2.Name = "label2";
            label2.Size = new Size(92, 32);
            label2.TabIndex = 2;
            label2.Text = "Khoá k:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(117, 235);
            label3.Name = "label3";
            label3.Size = new Size(100, 32);
            label3.TabIndex = 3;
            label3.Text = "Mã hoá:";
            // 
            // tbbr
            // 
            tbbr.Location = new Point(232, 60);
            tbbr.Name = "tbbr";
            tbbr.Size = new Size(263, 27);
            tbbr.TabIndex = 4;
            tbbr.TextChanged += tbbr_TextChanged;
            // 
            // num
            // 
            num.Location = new Point(232, 131);
            num.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            num.Name = "num";
            num.Size = new Size(150, 27);
            num.TabIndex = 5;
            // 
            // tbmh
            // 
            tbmh.Location = new Point(232, 241);
            tbmh.Name = "tbmh";
            tbmh.Size = new Size(263, 27);
            tbmh.TabIndex = 6;
            // 
            // btgm
            // 
            btgm.Font = new Font("Segoe UI", 14F);
            btgm.Location = new Point(349, 171);
            btgm.Name = "btgm";
            btgm.Size = new Size(115, 50);
            btgm.TabIndex = 0;
            btgm.Text = "Giải mã";
            btgm.UseVisualStyleBackColor = true;
            btgm.Click += btgm_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(115, 296);
            label4.Name = "label4";
            label4.Size = new Size(99, 32);
            label4.TabIndex = 2;
            label4.Text = "Giải mã:";
            // 
            // tbgm
            // 
            tbgm.Location = new Point(232, 301);
            tbgm.Name = "tbgm";
            tbgm.Size = new Size(263, 27);
            tbgm.TabIndex = 4;
            tbgm.TextChanged += tbbr_TextChanged;
            // 
            // btrs
            // 
            btrs.Location = new Point(213, 374);
            btrs.Name = "btrs";
            btrs.Size = new Size(94, 29);
            btrs.TabIndex = 7;
            btrs.Text = "Reset";
            btrs.UseVisualStyleBackColor = true;
            btrs.Click += btrs_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, savemh, savegm, closeToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // savemh
            // 
            savemh.Name = "savemh";
            savemh.Size = new Size(224, 26);
            savemh.Text = "Save Mã Hoá";
            savemh.Click += savemhToolStripMenuItem_Click;
            // 
            // savegm
            // 
            savegm.Name = "savegm";
            savegm.Size = new Size(224, 26);
            savegm.Text = "Save Giải Mã";
            savegm.Click += savegmToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(224, 26);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btrs);
            Controls.Add(tbmh);
            Controls.Add(num);
            Controls.Add(tbgm);
            Controls.Add(tbbr);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btgm);
            Controls.Add(btmh);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)num).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btmh;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbbr;
        private NumericUpDown num;
        private TextBox tbmh;
        private Button btgm;
        private Label label4;
        private TextBox tbgm;
        private Button btrs;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem savemh;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem savegm;
    }
}
