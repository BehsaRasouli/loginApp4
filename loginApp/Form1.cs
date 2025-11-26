using System.Windows.Forms;

namespace loginApp
{
    public partial class Form1 : Form
    {
        //made pas and name :
        private string name = "adminbehsa";
        private string pas = "12345678";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //form1:

            if (textBox1.Text.Equals(Name) && textBox2.Text.Equals(pas))
            {
                MessageBox.Show("login success");

            }
            else
            {
                if (!textBox1.Text.Equals(name))
                {
                    errorProvider1.SetError(textBox1, "user name is not correct");
                }

                if (!textBox2.Text.Equals(pas))
                {
                    errorProvider1.SetError(textBox2, "password is not correct ");

                }
                //form2:

                if (textBox1.Text.Equals(Name) && textBox2.Text.Equals(pas))
                {
                    MessageBox.Show("login success");
                    errorProvider1.Clear();
                    errorProvider2.Clear();
                }
                else
                {
                    if (!textBox1.Text.Equals(name))
                    {
                        errorProvider1.SetError(textBox1, "user name is not correct");
                    }
                    else
                        errorProvider1.Clear();
                    if (!textBox2.Text.Equals(pas))
                    {
                        errorProvider1.SetError(textBox2, "password is not correct");
                    }
                    else
                        errorProvider2.Clear();
                }
            }
        }
    }
}
