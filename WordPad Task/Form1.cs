namespace WordPad_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in FontFamily.Families)
            {
                fontsComboBox.Items.Add(item.Name.ToString());
            }


        }

        private void fontsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new(fontsComboBox.Text, richTextBox1.Font.Size);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, float.Parse(comboBox1.SelectedItem.ToString()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var netice = colorDialog1;
            if (netice.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = netice.Color;
            }

        }

        private void regularBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Regular);
        }

        private void boldFontStyleBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Bold);
        }

        private void UnderlinedBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Underline);
        }

        private void StrikeoutBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Strikeout);
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            var netice = openFileDialog1;
            netice.Filter = "Txt Files|*.txt";
            if (netice.ShowDialog() == DialogResult.OK)
            {
                string file = File.ReadAllText(netice.FileName.ToString());
                richTextBox1.Text = file;
            }
            else
                MessageBox.Show("Something went wrong");
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var netice = saveFileDialog1;
            if (netice.ShowDialog() == DialogResult.OK)
            {
                using Stream stream = File.Open(netice.FileName, FileMode.CreateNew);
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(richTextBox1.Text);
                };
            }

        }
    }
}