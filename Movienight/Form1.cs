using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Movienight
{
    public partial class Form1 : Form
    {
        private List<string> movies = new List<string>();
        private List<string> watchedMovies = new List<string>();

        public Form1()
        {
            InitializeComponent();
            LoadMovies();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void LoadMovies()
        {
            string filePath = "movies.txt";
            if (File.Exists(filePath))
            {
                movies = File.ReadAllLines(filePath).ToList();
                movies.Sort(); // Sort movies alphabetically
                movieListBox1.Items.AddRange(movies.ToArray());
            }
            else
            {
                MessageBox.Show("movies.txt not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void movieListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedMoviesListBox();
        }

        private void UpdateSelectedMoviesListBox()
        {
            selectedMoviesListBox.Items.Clear();
            var selectedMovies = movieListBox1.SelectedItems.Cast<string>().ToList();
            selectedMoviesListBox.Items.AddRange(selectedMovies.ToArray());
        }

        private void selectRandomMovieButton_Click(object sender, EventArgs e)
        {
            var selectedMovies = movieListBox1.SelectedItems.Cast<string>().ToList();
            if (selectedMovies.Count == 0)
            {
                selectedMovies = movies;
            }

            if (selectedMovies.Count > 0)
            {
                Random random = new Random();
                int index = random.Next(selectedMovies.Count);
                string randomMovie = selectedMovies[index];
                MessageBox.Show($"Selected Movie: {randomMovie}", "Random Movie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No movies available to select.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addToWatchedButton_Click(object sender, EventArgs e)
        {
            var selectedMovies = movieListBox1.SelectedItems.Cast<string>().ToList();
            foreach (var movie in selectedMovies)
            {
                if (movies.Contains(movie))
                {
                    movies.Remove(movie);
                }
            }

            // Update the movies.txt file
            File.WriteAllLines("movies.txt", movies);

            // Sort movies alphabetically
            movies.Sort();

            // Refresh the movieListBox1
            movieListBox1.Items.Clear();
            movieListBox1.Items.AddRange(movies.ToArray());

            // Update the selectedMoviesListBox
            UpdateSelectedMoviesListBox();
        }
    }
}