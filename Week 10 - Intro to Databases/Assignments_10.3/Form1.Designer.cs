namespace Assignments_10._3
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            addButton = new Button();
            yearRichTextBox = new RichTextBox();
            modelRichTextBox = new RichTextBox();
            makeRichTextBox = new RichTextBox();
            makeLabel = new Label();
            modelLabel = new Label();
            yearLabel = new Label();
            vinLabel = new Label();
            priceLabel = new Label();
            vinRichTextBox = new RichTextBox();
            priceRichTextBox = new RichTextBox();
            dataGridView1 = new DataGridView();
            CarsTableBindingSource = new BindingSource(components);
            delCarButton = new Button();
            searchLabel = new Label();
            searchRichTextBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CarsTableBindingSource).BeginInit();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(86, 409);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 0;
            addButton.Text = "Add Car";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // yearRichTextBox
            // 
            yearRichTextBox.Location = new Point(86, 374);
            yearRichTextBox.Name = "yearRichTextBox";
            yearRichTextBox.Size = new Size(125, 29);
            yearRichTextBox.TabIndex = 1;
            yearRichTextBox.Text = "";
            // 
            // modelRichTextBox
            // 
            modelRichTextBox.Location = new Point(86, 339);
            modelRichTextBox.Name = "modelRichTextBox";
            modelRichTextBox.Size = new Size(125, 29);
            modelRichTextBox.TabIndex = 2;
            modelRichTextBox.Text = "";
            // 
            // makeRichTextBox
            // 
            makeRichTextBox.Location = new Point(86, 304);
            makeRichTextBox.Name = "makeRichTextBox";
            makeRichTextBox.Size = new Size(125, 29);
            makeRichTextBox.TabIndex = 3;
            makeRichTextBox.Text = "";
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new Point(12, 307);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new Size(59, 20);
            makeLabel.TabIndex = 4;
            makeLabel.Text = "Make - ";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(12, 342);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(66, 20);
            modelLabel.TabIndex = 5;
            modelLabel.Text = "Model - ";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(12, 377);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(51, 20);
            yearLabel.TabIndex = 6;
            yearLabel.Text = "Year - ";
            // 
            // vinLabel
            // 
            vinLabel.AutoSize = true;
            vinLabel.Location = new Point(12, 237);
            vinLabel.Name = "vinLabel";
            vinLabel.Size = new Size(43, 20);
            vinLabel.TabIndex = 7;
            vinLabel.Text = "VIN -";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(12, 272);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(51, 20);
            priceLabel.TabIndex = 8;
            priceLabel.Text = "Price -";
            // 
            // vinRichTextBox
            // 
            vinRichTextBox.Location = new Point(86, 234);
            vinRichTextBox.Name = "vinRichTextBox";
            vinRichTextBox.Size = new Size(125, 29);
            vinRichTextBox.TabIndex = 9;
            vinRichTextBox.Text = "";
            // 
            // priceRichTextBox
            // 
            priceRichTextBox.Location = new Point(86, 269);
            priceRichTextBox.Name = "priceRichTextBox";
            priceRichTextBox.Size = new Size(125, 29);
            priceRichTextBox.TabIndex = 10;
            priceRichTextBox.Text = "";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = CarsTableBindingSource;
            dataGridView1.Location = new Point(217, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(571, 391);
            dataGridView1.TabIndex = 11;
            // 
            // delCarButton
            // 
            delCarButton.Location = new Point(694, 409);
            delCarButton.Name = "delCarButton";
            delCarButton.Size = new Size(94, 29);
            delCarButton.TabIndex = 12;
            delCarButton.Text = "Delete Car";
            delCarButton.UseVisualStyleBackColor = true;
            delCarButton.Click += delCarButton_Click;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(12, 12);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(117, 20);
            searchLabel.TabIndex = 13;
            searchLabel.Text = "Car Search (VIN)";
            // 
            // searchRichTextBox
            // 
            searchRichTextBox.Location = new Point(36, 35);
            searchRichTextBox.Name = "searchRichTextBox";
            searchRichTextBox.Size = new Size(175, 29);
            searchRichTextBox.TabIndex = 14;
            searchRichTextBox.Text = "";
            searchRichTextBox.TextChanged += searchRichTextBox_Changed;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchRichTextBox);
            Controls.Add(searchLabel);
            Controls.Add(delCarButton);
            Controls.Add(dataGridView1);
            Controls.Add(priceRichTextBox);
            Controls.Add(vinRichTextBox);
            Controls.Add(priceLabel);
            Controls.Add(vinLabel);
            Controls.Add(yearLabel);
            Controls.Add(modelLabel);
            Controls.Add(makeLabel);
            Controls.Add(makeRichTextBox);
            Controls.Add(modelRichTextBox);
            Controls.Add(yearRichTextBox);
            Controls.Add(addButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CarsTableBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private RichTextBox yearRichTextBox;
        private RichTextBox modelRichTextBox;
        private RichTextBox makeRichTextBox;
        private Label makeLabel;
        private Label modelLabel;
        private Label yearLabel;
        private Label vinLabel;
        private Label priceLabel;
        private RichTextBox vinRichTextBox;
        private RichTextBox priceRichTextBox;
        private DataGridView dataGridView1;
        private BindingSource CarsTableBindingSource;
        private Button delCarButton;
        private Label searchLabel;
        private RichTextBox searchRichTextBox;
    }
}
