namespace Assignment4._1._2
{
    public partial class Form1 : Form
    {
        MyMath myOps = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double.TryParse(num1TextBox.Text, out double a);
            double.TryParse(num2TextBox.Text, out double b);

            resultLabel.Text = (myOps.Add(a, b)).ToString();
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            double.TryParse(num1TextBox.Text, out double a);
            double.TryParse(num2TextBox.Text, out double b);

            resultLabel.Text = (myOps.Sub(a, b)).ToString();
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            double.TryParse(num1TextBox.Text, out double a);
            double.TryParse(num2TextBox.Text, out double b);

            resultLabel.Text = (myOps.Mult(a, b)).ToString();
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            double.TryParse(num1TextBox.Text, out double a);
            double.TryParse(num2TextBox.Text, out double b);

            resultLabel.Text = (myOps.Div(a, b)).ToString();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            num1TextBox.Text = "";
            num2TextBox.Text = "";
            resultLabel.Text = "";
        }
    }
}
