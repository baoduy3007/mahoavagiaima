namespace caesar
{
    partial class Form2
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            tbdv = new TextBox();
            tbdr = new TextBox();
            btmh = new Button();
            btgm = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label4 = new Label();
            tbkhoa = new TextBox();
            matran = new DataGridView();
            btclear = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)matran).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(1016, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, closeToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(181, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(181, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.X;
            closeToolStripMenuItem.Size = new Size(181, 26);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 55);
            label1.Name = "label1";
            label1.Size = new Size(91, 26);
            label1.TabIndex = 1;
            label1.Text = "Đầu vào";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(566, 55);
            label2.Name = "label2";
            label2.Size = new Size(75, 26);
            label2.TabIndex = 1;
            label2.Text = "Đầu ra";
            // 
            // tbdv
            // 
            tbdv.Location = new Point(30, 97);
            tbdv.Multiline = true;
            tbdv.Name = "tbdv";
            tbdv.Size = new Size(333, 261);
            tbdv.TabIndex = 2;
            tbdv.TextChanged += tbdv_TextChanged;
            // 
            // tbdr
            // 
            tbdr.Enabled = false;
            tbdr.Location = new Point(566, 97);
            tbdr.Multiline = true;
            tbdr.Name = "tbdr";
            tbdr.Size = new Size(333, 261);
            tbdr.TabIndex = 2;
            // 
            // btmh
            // 
            btmh.Enabled = false;
            btmh.Location = new Point(426, 139);
            btmh.Name = "btmh";
            btmh.Size = new Size(94, 29);
            btmh.TabIndex = 3;
            btmh.Text = "Mã hoá";
            btmh.UseVisualStyleBackColor = true;
            btmh.Click += btmh_Click;
            // 
            // btgm
            // 
            btgm.Enabled = false;
            btgm.Location = new Point(426, 204);
            btgm.Name = "btgm";
            btgm.Size = new Size(94, 29);
            btgm.TabIndex = 3;
            btgm.Text = "Giải mã";
            btgm.UseVisualStyleBackColor = true;
            btgm.Click += btgm_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 426);
            label4.Name = "label4";
            label4.Size = new Size(62, 26);
            label4.TabIndex = 1;
            label4.Text = "Khoá";
            // 
            // tbkhoa
            // 
            tbkhoa.Location = new Point(31, 469);
            tbkhoa.Name = "tbkhoa";
            tbkhoa.Size = new Size(125, 34);
            tbkhoa.TabIndex = 4;
            // 
            // matran
            // 
            matran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matran.Location = new Point(190, 469);
            matran.Name = "matran";
            matran.RowHeadersWidth = 51;
            matran.Size = new Size(760, 188);
            matran.TabIndex = 5;
            // 
            // btclear
            // 
            btclear.Enabled = false;
            btclear.Location = new Point(426, 268);
            btclear.Name = "btclear";
            btclear.Size = new Size(94, 29);
            btclear.TabIndex = 3;
            btclear.Text = "Clear";
            btclear.UseVisualStyleBackColor = true;
            btclear.Click += btgm_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 715);
            Controls.Add(matran);
            Controls.Add(tbkhoa);
            Controls.Add(btclear);
            Controls.Add(btgm);
            Controls.Add(btmh);
            Controls.Add(tbdr);
            Controls.Add(tbdv);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)matran).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Label label1;
        private Label label2;
        private TextBox tbdv;
        private TextBox tbdr;
        private Button btmh;
        private Button btgm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label4;
        private TextBox tbkhoa;
        private DataGridView matran;
        private Button btclear;
    }
}