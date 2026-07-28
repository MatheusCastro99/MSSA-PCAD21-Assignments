namespace Assignment4._1._2
{
    partial class CalculatorApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            num1 = new Label();
            num2 = new Label();
            result = new Label();
            num1TextBox = new RichTextBox();
            num2TextBox = new RichTextBox();
            resultLabel = new Label();
            addButton = new Button();
            subButton = new Button();
            multButton = new Button();
            divButton = new Button();
            resetButton = new Button();
            SuspendLayout();
            // 
            // num1
            // 
            num1.AutoSize = true;
            num1.Location = new Point(36, 33);
            num1.Name = "num1";
            num1.Size = new Size(82, 20);
            num1.TabIndex = 0;
            num1.Text = "Number 1: ";
            // 
            // num2
            // 
            num2.AutoSize = true;
            num2.Location = new Point(36, 88);
            num2.Name = "num2";
            num2.Size = new Size(82, 20);
            num2.TabIndex = 1;
            num2.Text = "Number 2: ";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(62, 152);
            result.Name = "result";
            result.Size = new Size(56, 20);
            result.TabIndex = 2;
            result.Text = "Result: ";
            // 
            // num1TextBox
            // 
            num1TextBox.Location = new Point(124, 30);
            num1TextBox.Name = "num1TextBox";
            num1TextBox.Size = new Size(149, 28);
            num1TextBox.TabIndex = 3;
            num1TextBox.Text = "";
            num1TextBox.TextChanged += ValidateNum;
            // 
            // num2TextBox
            // 
            num2TextBox.Location = new Point(124, 85);
            num2TextBox.Name = "num2TextBox";
            num2TextBox.Size = new Size(149, 28);
            num2TextBox.TabIndex = 4;
            num2TextBox.Text = "";
            num2TextBox.TextChanged += ValidateNum;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.BackColor = SystemColors.ControlDark;
            resultLabel.BorderStyle = BorderStyle.Fixed3D;
            resultLabel.Location = new Point(124, 152);
            resultLabel.MinimumSize = new Size(150, 15);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(150, 22);
            resultLabel.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new Point(477, 24);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 6;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // subButton
            // 
            subButton.Location = new Point(614, 24);
            subButton.Name = "subButton";
            subButton.Size = new Size(94, 29);
            subButton.TabIndex = 7;
            subButton.Text = "Subtract";
            subButton.UseVisualStyleBackColor = true;
            subButton.Click += subButton_Click;
            // 
            // multButton
            // 
            multButton.Location = new Point(477, 79);
            multButton.Name = "multButton";
            multButton.Size = new Size(94, 29);
            multButton.TabIndex = 8;
            multButton.Text = "Multiply";
            multButton.UseVisualStyleBackColor = true;
            multButton.Click += multButton_Click;
            // 
            // divButton
            // 
            divButton.Location = new Point(614, 79);
            divButton.Name = "divButton";
            divButton.Size = new Size(94, 29);
            divButton.TabIndex = 9;
            divButton.Text = "Divide";
            divButton.UseVisualStyleBackColor = true;
            divButton.Click += divButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(546, 143);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(94, 29);
            resetButton.TabIndex = 10;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // CalculatorApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resetButton);
            Controls.Add(divButton);
            Controls.Add(multButton);
            Controls.Add(subButton);
            Controls.Add(addButton);
            Controls.Add(resultLabel);
            Controls.Add(num2TextBox);
            Controls.Add(num1TextBox);
            Controls.Add(result);
            Controls.Add(num2);
            Controls.Add(num1);
            Name = "CalculatorApp";
            Text = "Calculator App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label num1;
        private Label num2;
        private Label result;
        private RichTextBox num1TextBox;
        private RichTextBox num2TextBox;
        private Label resultLabel;
        private Button addButton;
        private Button subButton;
        private Button multButton;
        private Button divButton;
        private Button resetButton;
    }
}
