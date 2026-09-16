using System.ComponentModel;

namespace Assignment_11._3
{
    public partial class Form1 : Form
    {
        MovieRentalContext movieRentalDb;
        BindingList<Movie> moviesBinding = new();
        BindingList<Genre> genreBinding = new();
        public Form1()
        {
            InitializeComponent();
            movieRentalDb = new();

            movieRentalDb.Database.EnsureDeleted();
            movieRentalDb.Database.EnsureCreated();

            UpdateMovieTable();
            UpdateGenreTable();
        }

        public void UpdateMovieTable()
        {
            moviesBinding = new(movieRentalDb.Movies.ToList());
            moviesDataGridView.DataSource = moviesBinding;

            moviesDataGridView.Columns["MovieId"].Visible = false;
            moviesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void UpdateGenreTable()
        {
            genreBinding = new(movieRentalDb.Genres.ToList());
            genreDataGridView.DataSource = genreBinding;

            genreDataGridView.Columns["GenreId"].Visible = false;
            genreDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FilterByGenre(object sender, DataGridViewCellEventArgs e)
        {
            if (genreDataGridView.SelectedCells.Count != 1)
            {
                UpdateMovieTable();
                return;
            }

            List<Movie> filteredMovies = new(
                movieRentalDb.Movies
                    .Where(m => m.Genre == genreDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString())
                    .ToList()); //checks movie.genre against table cell 1 (GenreName)

            moviesBinding = new(filteredMovies);
            moviesDataGridView.DataSource = moviesBinding;
        }

        public void ResetFields()
        {
            movieNameRichTextBox.Clear();
            movieGenreRichTextBox.Clear();
            movieYearRichTextBox.Clear();
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(addGenreRichTextBox.Text))
            {
                if (movieRentalDb.Genres.Any(g => g.Name == addGenreRichTextBox.Text))
                {
                    MessageBox.Show("Genre already exists.");
                    return;
                }

                Genre newGenre = new() { Name = addGenreRichTextBox.Text };
                movieRentalDb.Genres.Add(newGenre);
                movieRentalDb.SaveChanges();
                UpdateGenreTable();

                addGenreRichTextBox.Clear();
            }
        }

        private async void addMovieButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(movieNameRichTextBox.Text) && !string.IsNullOrEmpty(movieGenreRichTextBox.Text) && !string.IsNullOrEmpty(movieYearRichTextBox.Text))
            {
                if (!int.TryParse(movieYearRichTextBox.Text, out int releaseYear))
                {
                    MessageBox.Show("Please enter a valid year.");
                    return;
                }

                if (!movieRentalDb.Genres.Any(g => g.Name == movieGenreRichTextBox.Text)) //Checls Genre agains Database and create it if it doesn't exist
                {
                    string newGenreName = movieGenreRichTextBox.Text;

                    await Task.Run(() =>
                    {
                        Genre newGenre = new() { Name = newGenreName };
                        movieRentalDb.Genres.Add(newGenre);
                        movieRentalDb.SaveChanges();
                    });

                    UpdateGenreTable();
                }

                Movie newMovie = new()
                {
                    Name = movieNameRichTextBox.Text,
                    Genre = movieGenreRichTextBox.Text,
                    ReleaseYear = releaseYear
                };
                movieRentalDb.Movies.Add(newMovie);
                await movieRentalDb.SaveChangesAsync();
                UpdateMovieTable();

                ResetFields();
            }
        }

        private void GenreViewClearSelection(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                genreDataGridView.ClearSelection();
                genreDataGridView.CurrentCell = null;
                UpdateMovieTable();
            }
        }

        private void deleteMovieButton_Click(object sender, EventArgs e)
        {
            if (moviesDataGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a movie to delete.");
                return;
            }

            var selectedRow = moviesDataGridView.SelectedRows[0];
            var movieToDelete = selectedRow.DataBoundItem as Movie;

            if (movieToDelete != null)
            {
                movieRentalDb.Movies.Remove(movieToDelete);
                movieRentalDb.SaveChanges();
                UpdateMovieTable();
            }
        }
    }
}
