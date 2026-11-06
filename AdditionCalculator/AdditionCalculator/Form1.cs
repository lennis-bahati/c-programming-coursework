namespace AdditionCalculator
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double firstNumber;
            double secondNumber;
            double result;

            firstNumber = Convert.ToDouble(txtFirstNumber.Text);
            secondNumber = Convert.ToDouble(txtSecondNumber.Text);

            result = firstNumber + secondNumber;
            lblResult.Text = "Result: " + result.ToString();
        }

        private void txtSecondNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
