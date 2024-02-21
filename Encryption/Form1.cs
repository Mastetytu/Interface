using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            ColorDialog colorDialog1 = new ColorDialog();
            FontDialog fontDialog2 = new FontDialog();
            InitializeComponent();
            colorDialog1.FullOpen = true;
            colorDialog1.Color = this.BackColor;
            fontDialog2.Font = fontDialog2.Font;
            


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true; //Мультиселект
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true; //Мультиселект
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string dir = @"C:\Users\aleks\source\repos\Interface\Encryption\text"; //Директория куда скидываем файлы
                                                                                       //массив
                string[] filenames = openFileDialog.FileNames;
                //Получаем путь к выделенным файлам
                FileInfo fi = new FileInfo(openFileDialog.FileName);
                string dirSource = fi.DirectoryName;
                //Сохранение файла в указанную директорию
                foreach (String file in filenames)
                {
                    string fname = file.Substring(dirSource.Length + 1);
                    System.IO.File.Copy(Path.Combine(dirSource, fname), Path.Combine(dir, fname), true);
                }
            }
        }

        private void сolorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
                ColorDialog colorDialog1 = new ColorDialog();
                if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

            this.BackColor = colorDialog1.Color;

        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog2 = new FontDialog();
            if (fontDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            this.Font = fontDialog2.Font;
            // установка цвета шрифта
            this.ForeColor = fontDialog2.Color;
        }
    }
}
