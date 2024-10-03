using System.Diagnostics.Metrics;

namespace caesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbbr_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmh_Click(object sender, EventArgs e)
        {
            int key = (int)num.Value;
            tbmh.Text = mahoa(tbbr.Text, key);
        }

        private void btgm_Click(object sender, EventArgs e)
        {
            int key = (int)num.Value;
            tbgm.Text = giaima(tbmh.Text, key);
        }


        private string mahoa(string text, int key)
        {
            key = key % 26;
            char[] vanban = text.ToCharArray();
            for (int i = 0; i < vanban.Length; i++)
            {
                char kytu = vanban[i];
                if (char.IsLetter(kytu))
                {
                    char offset = char.IsUpper(kytu) ? 'A' : 'a';
                    kytu = (char)(((kytu + key - offset) % 26) + offset);
                }
                vanban[i] = kytu;
            }
            return new string(vanban);
        }

        private string giaima(string text, int key)
        {
            key = key % 26;
            char[] vanban = text.ToCharArray();
            for (int i = 0; i < vanban.Length; i++)
            {
                char kytu = vanban[i];
                if (char.IsLetter(kytu))
                {
                    char offset = char.IsUpper(kytu) ? 'A' : 'a';
                    kytu = (char)(((kytu - offset - key + 26) % 26) + offset);
                }
                vanban[i] = kytu;
            }
            return new string(vanban);
        }


        private void btrs_Click(object sender, EventArgs e)
        {
            tbmh.Text = "";
            tbgm.Text = "";
            tbbr.Text = "";
            num.Value = 0;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                tbbr.Text = File.ReadAllText(filePath);
            }
        }

        private void savemhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName,"Văn bản đầu vào là:\n" + tbbr.Text +"\nVăn bản đã mã hoá là:\n" + tbmh.Text);
                MessageBox.Show("Đã lưu file Mã hoá");
            }
        }

        private void savegmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, "Văn bản đầu vào là:\n" + tbbr.Text + "\nVăn bản đã giải mà là:\n" + tbgm.Text);
                MessageBox.Show("Đã lưu file Giải mã");
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
