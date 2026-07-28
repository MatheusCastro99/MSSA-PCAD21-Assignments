namespace Assignment4._1._2
{
    public partial class CalculatorApp : Form
    {
        MyMath myOps = new();
        public CalculatorApp()
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

            num1TextBox.BackColor = default(Color);
            num2TextBox.BackColor = default(Color);

            ToggleButtons(true);
        }

        private void ValidateNum(object sender, EventArgs e)
        {
            RichTextBox box = (RichTextBox)sender;
            if (double.TryParse(box.Text, out double var))
            {
                box.BackColor = Color.LightGreen;

                ToggleButtons(true);
            }
            else
            {
                box.BackColor = Color.LightPink;

                ToggleButtons(false);
            }

            if (box.Name == "num2TextBox" && box.Text == "0")
            {
                divButton.Enabled = false;
            }
        }

        private void ToggleButtons(bool isEnabled)
        {
            addButton.Enabled = isEnabled;
            subButton.Enabled = isEnabled;
            multButton.Enabled = isEnabled;
            divButton.Enabled = isEnabled;
        }
    }
}
