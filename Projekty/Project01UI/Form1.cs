using System.Text.RegularExpressions;

namespace Project01UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string paragraph = richTextBox1.Text;

            textBox1.Text = paragraph.Length.ToString();

            bool containsLetters = Regex.IsMatch(paragraph, @"[a-zA-Z]");
            bool containsNumbers = Regex.IsMatch(paragraph, @"\d");
            bool containsSymbols = Regex.IsMatch(paragraph, @"[~`!@#$%^&*()?]");

            textBox2.Text = containsLetters.ToString();
            textBox3.Text = containsNumbers.ToString();
            textBox4.Text = containsSymbols.ToString();

        }
        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}