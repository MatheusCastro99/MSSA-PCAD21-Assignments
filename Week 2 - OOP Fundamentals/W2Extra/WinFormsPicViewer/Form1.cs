namespace WinFormsPicViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowPicButton_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user clicks OK, load the
            // picture that the user chose.

            if (ShowPictureDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(ShowPictureDialog.FileName);
            }
            
        }

        private void ClearPicButton_Click(object sender, EventArgs e)
        {  
            //Clears picture
            pictureBox1.Image = null;
        }

        private void SetBackgroundButton_Click(object sender, EventArgs e)
        {
            // Show the color dialog box. If the user clicks OK, change the
            // PictureBox control's background to the color the user chose.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            //Closes form
            this.Close();

        }

        private void StretchCheckBox(object sender, EventArgs e)
        {
            // If the user selects the Stretch check box, 
            // change the PictureBox's
            // SizeMode property to "Stretch". If the user clears 
            // the check box, change it to "Normal".
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
