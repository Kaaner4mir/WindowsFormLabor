namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        double number1;
        double number2;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNumber1.Text);
            number2 = Convert.ToDouble(txtNumber2.Text);
            txtResult.Text = (number1 + number2).ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNumber1.Text);
            number2 = Convert.ToDouble(txtNumber2.Text);
            txtResult.Text = (number1 - number2).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNumber1.Text);
            number2 = Convert.ToDouble(txtNumber2.Text);
            txtResult.Text = (number1 * number2).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNumber1.Text);
            number2 = Convert.ToDouble(txtNumber2.Text);

            if (number1 == 0 && number2 == 0)
            {
                MessageBox.Show("Indeterminate form: 0 divided by 0 is undefined.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Text = "";
            }

            if (number2 == 0)
            {
                MessageBox.Show("Division by zero is not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Text = "";
                return;
            }

            txtResult.Text = (number1 / number2).ToString();
        }

        private void btnBase_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNumber1.Text);
            number2 = Convert.ToDouble(txtNumber2.Text);

            if (number1 == 0 && number2 == 0)
            {
                MessageBox.Show("Indeterminate form: 0 raised to the power of 0 is undefined.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Text = "";
                return;
            }

            txtResult.Text = Math.Pow(number1, number2).ToString();
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNumber1.Text);
            number2 = Convert.ToDouble(txtNumber2.Text);

            if (number2 == 0)
            {
                MessageBox.Show("Cannot compute the zeroth root.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Text = "";
                return;
            }

            txtResult.Text = Math.Pow(number1, 1.0 / number2).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = "";
            txtNumber2.Text = "";
            txtResult.Text = "";
        }
    }
}
