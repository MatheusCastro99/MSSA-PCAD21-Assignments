using System.Diagnostics;
using System.Media;

namespace WinFormsMatchingGame
{
    public partial class MatchingGameForm : Form
    {
        public MatchingGameForm()
        {
            InitializeComponent();

            InitializeSoundPlayers();

            AssignIconsToSquares();
        }

        // firstClicked points to the first Label control 
        // that the player clicks, but it will be null 
        // if the player hasn't clicked a label yet
        Label firstClicked = null;

        // secondClicked points to the second Label control 
        // that the player clicks
        Label secondClicked = null;

        private SoundPlayer clickSound;
        private SoundPlayer celebrateSound;

        private void InitializeSoundPlayers()
        {
            try
            {
                // Get the project root directory
                string projectRoot = AppDomain.CurrentDomain.BaseDirectory;

                // Initialize click sound
                string clickSoundPath = Path.Combine(projectRoot, "Components", "click.wav");
                if (File.Exists(clickSoundPath))
                {
                    clickSound = new SoundPlayer(clickSoundPath);

                    Debug.WriteLine("ClickSound Loaded");
                }

                // Initialize celebration sound
                string celebrateSoundPath = Path.Combine(projectRoot, "Components", "celebrate.wav");
                if (File.Exists(celebrateSoundPath))
                {
                    celebrateSound = new SoundPlayer(celebrateSoundPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sound files: {ex.Message}", "Sound Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            // The timer is only on after two non-matching 
            // icons have been shown to the player, 
            // so ignore any clicks if the timer is running
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                // If firstClicked is null, this is the first icon 
                // in the pair that the player clicked,
                // so set firstClicked to the label that the player 
                // clicked, change its color to black, and return
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    PlayClickSound();

                    return;
                }

                // If the player gets this far, the timer isn't
                // running and firstClicked isn't null,
                // so this must be the second icon the player clicked
                // Set its color to black
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                PlayClickSound();

                // If the player clicked two matching icons, keep them 
                // black and reset firstClicked and secondClicked 
                // so the player can click another icon
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;

                    Thread.Sleep(1000);
                    PlayCelebrationSound();

                    CheckForWinner();

                    return;
                }

                // If the player gets this far, the player 
                // clicked two different icons, so start the 
                // timer (which will wait three quarters of 
                // a second, and then hide the icons)
                timer1.Start();
            }
        }

        /// <summary>
        /// This timer is started when the player clicks 
        /// two icons that don't match,
        /// so it counts three quarters of a second 
        /// and then turns itself off and hides both icons
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            timer1.Stop();

            // Hide both icons
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            // Reset firstClicked and secondClicked 
            // so the next time a label is
            // clicked, the program knows it's the first click
            firstClicked = null;
            secondClicked = null;
        }

        private void PlayClickSound()
        {
            try
            {
                if (clickSound != null)
                {
                    clickSound.Play();
                    // Debug.WriteLine("ClickSound Played!");
                }
            }
            catch (Exception ex)
            {
                // Silently fail - don't disrupt gameplay if sound fails
                System.Diagnostics.Debug.WriteLine($"Error playing click sound: {ex.Message}");
            }
        }

        /// <summary>
        /// Play the celebration sound effect for matched pairs
        /// </summary>
        private void PlayCelebrationSound()
        {
            try
            {
                if (celebrateSound != null)
                {
                    celebrateSound.Play();
                    // Debug.WriteLine("CelebrateSound Played!");
                }
            }
            catch (Exception ex)
            {
                // Silently fail - don't disrupt gameplay if sound fails
                System.Diagnostics.Debug.WriteLine($"Error playing celebration sound: {ex.Message}");
            }
        }
        private void CheckForWinner()
        {
            // Go through all of the labels in the TableLayoutPanel, 
            // checking each one to see if its icon is matched
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            // If the loop didn’t return, it didn't find
            // any unmatched icons
            // That means the user won. Show a message and close the form
            MessageBox.Show("You matched all the icons!", "Congratulations");
            Close();
        }
    }
}
