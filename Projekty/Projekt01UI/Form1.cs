using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Projekt01UI

{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tekst = richTextBox1.Text;
            textBox1.Text = tekst.Length.ToString();
            textBox2.Text = Regex.IsMatch(tekst, @"[a-zA-z]") == true ? "TAK" : "NIE";
            textBox3.Text = Regex.IsMatch(tekst, @"\d") == true ? "TAK" : "NIE";
            textBox4.Text = Regex.IsMatch(tekst, @"[\~`!@#$%^&*()?]") == true ? "TAK" : "NIE";
        }
    }
}