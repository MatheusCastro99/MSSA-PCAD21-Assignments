namespace WinFormsPicViewer
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ShowPicButton = new Button();
            ClearPicButton = new Button();
            SetBackgroundButton = new Button();
            CloseButton = new Button();
            ShowPictureDialog = new OpenFileDialog();
            colorDialog1 = new ColorDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.625F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.02817F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9718313F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 2);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(794, 390);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 399);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(77, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Stretch";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += StretchCheckBox;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(ShowPicButton);
            flowLayoutPanel1.Controls.Add(ClearPicButton);
            flowLayoutPanel1.Controls.Add(SetBackgroundButton);
            flowLayoutPanel1.Controls.Add(CloseButton);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(142, 399);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(646, 48);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // ShowPicButton
            // 
            ShowPicButton.AutoSize = true;
            ShowPicButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ShowPicButton.Location = new Point(527, 3);
            ShowPicButton.Name = "ShowPicButton";
            ShowPicButton.Size = new Size(116, 30);
            ShowPicButton.TabIndex = 0;
            ShowPicButton.Text = "Show a Picture";
            ShowPicButton.UseVisualStyleBackColor = true;
            ShowPicButton.Click += ShowPicButton_Click;
            // 
            // ClearPicButton
            // 
            ClearPicButton.AutoSize = true;
            ClearPicButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClearPicButton.Location = new Point(419, 3);
            ClearPicButton.Name = "ClearPicButton";
            ClearPicButton.Size = new Size(102, 30);
            ClearPicButton.TabIndex = 1;
            ClearPicButton.Text = "Clear Picture";
            ClearPicButton.UseVisualStyleBackColor = true;
            ClearPicButton.Click += ClearPicButton_Click;
            // 
            // SetBackgroundButton
            // 
            SetBackgroundButton.AutoSize = true;
            SetBackgroundButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SetBackgroundButton.Location = new Point(289, 3);
            SetBackgroundButton.Name = "SetBackgroundButton";
            SetBackgroundButton.Size = new Size(124, 30);
            SetBackgroundButton.TabIndex = 2;
            SetBackgroundButton.Text = "Set BackGround";
            SetBackgroundButton.UseVisualStyleBackColor = true;
            SetBackgroundButton.Click += SetBackgroundButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CloseButton.Location = new Point(228, 3);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(55, 30);
            CloseButton.TabIndex = 3;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // ShowPictureDialog
            // 
            ShowPictureDialog.FileName = "ShowPictureDialog";
            ShowPictureDialog.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            ShowPictureDialog.Title = "Select a Picture File";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "PicViewerTest";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button ShowPicButton;
        private Button ClearPicButton;
        private Button SetBackgroundButton;
        private Button CloseButton;
        private OpenFileDialog ShowPictureDialog;
        private ColorDialog colorDialog1;
    }
}
