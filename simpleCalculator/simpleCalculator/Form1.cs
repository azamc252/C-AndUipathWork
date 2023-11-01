namespace simpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNumbBox.Text) | string.IsNullOrEmpty(secondNumbBox.Text))
            {
                MessageBox.Show("Please Enter A Number Into Each Box");
            }
            else
            {
                double firstNumb = double.Parse(firstNumbBox.Text);
                double secondNumb = double.Parse(secondNumbBox.Text);
                double result = firstNumb + secondNumb;
                result = Math.Round(result, 2);
                resultBox.Text = result.ToString();
            }


        }

        private void subtractBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNumbBox.Text) | string.IsNullOrEmpty(secondNumbBox.Text))
            {
                MessageBox.Show("Please Enter A Number Into Each Box");
            }
            else
            {
                double firstNumb = double.Parse(firstNumbBox.Text);
                double secondNumb = double.Parse(secondNumbBox.Text);
                double result = firstNumb - secondNumb;
                result = Math.Round(result, 2);
                resultBox.Text = result.ToString();
            }
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNumbBox.Text) | string.IsNullOrEmpty(secondNumbBox.Text))
            {
                MessageBox.Show("Please Enter A Number Into Each Box");
            }
            else
            {
                double firstNumb = double.Parse(firstNumbBox.Text);
                double secondNumb = double.Parse(secondNumbBox.Text);
                double result = firstNumb * secondNumb;
                result = Math.Round(result, 2);
                resultBox.Text = result.ToString();
            }
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNumbBox.Text) | string.IsNullOrEmpty(secondNumbBox.Text))
            {
                MessageBox.Show("Please Enter A Number Into Each Box");
            }
            else
            {
                double firstNumb = double.Parse(firstNumbBox.Text);
                double secondNumb = double.Parse(secondNumbBox.Text);
                double result = firstNumb / secondNumb;
                result = Math.Round(result, 2);
                resultBox.Text = result.ToString();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            firstNumbBox.Text = "";
            secondNumbBox.Text = "";
            resultBox.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            firstNumbBox.Text = resultBox.Text;
            secondNumbBox.Text = "";
            resultBox.Text = "";

        }

        private void firstNumbBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void secondNumbBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}