namespace Assignment_11._3
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
            moviesDataGridView = new DataGridView();
            moviesViewBindingSource = new BindingSource(components);
            genreDataGridView = new DataGridView();
            GenreViewBindingSource = new BindingSource(components);
            addGenreRichTextBox = new RichTextBox();
            movieNameRichTextBox = new RichTextBox();
            movieYearRichTextBox = new RichTextBox();
            movieGenreRichTextBox = new RichTextBox();
            addGenreButton = new Button();
            addMovieButton = new Button();
            genreNameLabel = new Label();
            movieNameLabel = new Label();
            yearLabel = new Label();
            movieGenreLabel = new Label();
            deleteMovieButton = new Button();
            ((System.ComponentModel.ISupportInitialize)moviesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moviesViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)genreDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GenreViewBindingSource).BeginInit();
            SuspendLayout();
            // 
            // moviesDataGridView
            // 
            moviesDataGridView.AllowUserToAddRows = false;
            moviesDataGridView.AllowUserToDeleteRows = false;
            moviesDataGridView.AutoGenerateColumns = true;
            moviesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            moviesDataGridView.DataSource = moviesViewBindingSource;
            moviesDataGridView.Location = new Point(357, 12);
            moviesDataGridView.Name = "moviesDataGridView";
            moviesDataGridView.ReadOnly = true;
            moviesDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            moviesDataGridView.Size = new Size(431, 188);
            moviesDataGridView.TabIndex = 0;
            // 
            // genreDataGridView
            // 
            genreDataGridView.AllowUserToAddRows = false;
            genreDataGridView.AllowUserToDeleteRows = false;
            genreDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            genreDataGridView.Location = new Point(12, 12);
            genreDataGridView.Name = "genreDataGridView";
            genreDataGridView.ReadOnly = true;
            genreDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            genreDataGridView.Size = new Size(294, 188);
            genreDataGridView.TabIndex = 1;
            genreDataGridView.CellEnter += FilterByGenre;
            genreDataGridView.KeyDown += GenreViewClearSelection;
            // 
            // addGenreRichTextBox
            // 
            addGenreRichTextBox.Location = new Point(12, 232);
            addGenreRichTextBox.Name = "addGenreRichTextBox";
            addGenreRichTextBox.Size = new Size(142, 26);
            addGenreRichTextBox.TabIndex = 2;
            addGenreRichTextBox.Text = "";
            // 
            // movieNameRichTextBox
            // 
            movieNameRichTextBox.Location = new Point(357, 232);
            movieNameRichTextBox.Name = "movieNameRichTextBox";
            movieNameRichTextBox.Size = new Size(142, 26);
            movieNameRichTextBox.TabIndex = 3;
            movieNameRichTextBox.Text = "";
            // 
            // movieYearRichTextBox
            // 
            movieYearRichTextBox.Location = new Point(532, 232);
            movieYearRichTextBox.Name = "movieYearRichTextBox";
            movieYearRichTextBox.Size = new Size(142, 26);
            movieYearRichTextBox.TabIndex = 4;
            movieYearRichTextBox.Text = "";
            // 
            // movieGenreRichTextBox
            // 
            movieGenreRichTextBox.Location = new Point(357, 295);
            movieGenreRichTextBox.Name = "movieGenreRichTextBox";
            movieGenreRichTextBox.Size = new Size(142, 26);
            movieGenreRichTextBox.TabIndex = 5;
            movieGenreRichTextBox.Text = "";
            // 
            // addGenreButton
            // 
            addGenreButton.Location = new Point(160, 229);
            addGenreButton.Name = "addGenreButton";
            addGenreButton.Size = new Size(94, 29);
            addGenreButton.TabIndex = 6;
            addGenreButton.Text = "Add Genre";
            addGenreButton.UseVisualStyleBackColor = true;
            addGenreButton.Click += addGenreButton_Click;
            // 
            // addMovieButton
            // 
            addMovieButton.Location = new Point(532, 292);
            addMovieButton.Name = "addMovieButton";
            addMovieButton.Size = new Size(94, 29);
            addMovieButton.TabIndex = 7;
            addMovieButton.Text = "Add Movie";
            addMovieButton.UseVisualStyleBackColor = true;
            addMovieButton.Click += addMovieButton_Click;
            // 
            // genreNameLabel
            // 
            genreNameLabel.AutoSize = true;
            genreNameLabel.Location = new Point(12, 209);
            genreNameLabel.Name = "genreNameLabel";
            genreNameLabel.Size = new Size(92, 20);
            genreNameLabel.TabIndex = 8;
            genreNameLabel.Text = "Genre Name";
            // 
            // movieNameLabel
            // 
            movieNameLabel.AutoSize = true;
            movieNameLabel.Location = new Point(357, 209);
            movieNameLabel.Name = "movieNameLabel";
            movieNameLabel.Size = new Size(94, 20);
            movieNameLabel.TabIndex = 9;
            movieNameLabel.Text = "Movie Name";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(532, 209);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(92, 20);
            yearLabel.TabIndex = 10;
            yearLabel.Text = "Release Year";
            // 
            // movieGenreLabel
            // 
            movieGenreLabel.AutoSize = true;
            movieGenreLabel.Location = new Point(357, 272);
            movieGenreLabel.Name = "movieGenreLabel";
            movieGenreLabel.Size = new Size(93, 20);
            movieGenreLabel.TabIndex = 11;
            movieGenreLabel.Text = "Movie Genre";
            // 
            // deleteMovieButton
            // 
            deleteMovieButton.Location = new Point(12, 348);
            deleteMovieButton.Name = "deleteMovieButton";
            deleteMovieButton.Size = new Size(94, 29);
            deleteMovieButton.TabIndex = 12;
            deleteMovieButton.Text = "Delete Movie";
            deleteMovieButton.UseVisualStyleBackColor = true;
            deleteMovieButton.Click += deleteMovieButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteMovieButton);
            Controls.Add(movieGenreLabel);
            Controls.Add(yearLabel);
            Controls.Add(movieNameLabel);
            Controls.Add(genreNameLabel);
            Controls.Add(addMovieButton);
            Controls.Add(addGenreButton);
            Controls.Add(movieGenreRichTextBox);
            Controls.Add(movieYearRichTextBox);
            Controls.Add(movieNameRichTextBox);
            Controls.Add(addGenreRichTextBox);
            Controls.Add(genreDataGridView);
            Controls.Add(moviesDataGridView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)moviesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)moviesViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)genreDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)GenreViewBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView moviesDataGridView;
        private BindingSource moviesViewBindingSource;
        private DataGridView genreDataGridView;
        private BindingSource GenreViewBindingSource;
        private RichTextBox addGenreRichTextBox;
        private RichTextBox movieNameRichTextBox;
        private RichTextBox movieYearRichTextBox;
        private RichTextBox movieGenreRichTextBox;
        private Button addGenreButton;
        private Button addMovieButton;
        private Label genreNameLabel;
        private Label movieNameLabel;
        private Label yearLabel;
        private Label movieGenreLabel;
        private Button deleteMovieButton;
    }
}
