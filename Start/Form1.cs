using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var p = new Process();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    p.StartInfo.FileName = @"C:\Users\aleks\source\repos\Interface\Lottery\bin\Debug\net8.0-windows\Lottery";
                    p.Start();
                    break;
                case 1:
                    p.StartInfo.FileName = @"C:\Users\aleks\source\repos\Interface\Encryption\bin\Debug\net8.0-windows\Encryption";
                    p.Start();
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            




        }
    }
}
