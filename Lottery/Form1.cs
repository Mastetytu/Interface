namespace Lottery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Lottery Play = new Lottery();
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox6.Text);
            int c = Convert.ToInt32(textBox5.Text);
            int d = Convert.ToInt32(textBox4.Text);
            int f = Convert.ToInt32(textBox3.Text);
            Play.Vnosim_chisla(a);
            Play.Vnosim_chisla(b);
            Play.Vnosim_chisla(c);
            Play.Vnosim_chisla(d);
            Play.Vnosim_chisla(f);
            Play.Random_chisla();
            Play.Proverka();

            switch (Play.win)
            {
                case 1:
                    textBox8.Text = $"������ ���� �����: ! \n��� ������� �������� 5 ����������� ������!";
                    break;
                case 2:
                    textBox8.Text = $"������� ��� ������: ! \n��� ������� �������� 25 ����������� ������!";
                    break;
                case 3:
                    textBox8.Text = $"������� ��� ������: ! \n��� ������� �������� 125 ����������� ������!";
                    break;
                case 4:
                    textBox8.Text = $"������� ������ ������: ! \n��� ������� �������� 625 ����������� ������!";
                    break;
                case 5:
                    textBox8.Text = "������� ��� ������!!! \n��� ������� �������� 3125 ����������� ������!";
                    break;
                default:
                    textBox8.Text = "� ���������, �� ���� ����� �� ������ :(";
                    break;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {



        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
