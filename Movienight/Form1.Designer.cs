namespace Movienight
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.movieListBox1 = new System.Windows.Forms.ListBox();
            this.selectRandomMovieButton = new System.Windows.Forms.Button();
            this.addToWatchedButton = new System.Windows.Forms.Button();
            this.selectedMoviesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // movieListBox1
            // 
            this.movieListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movieListBox1.FormattingEnabled = true;
            this.movieListBox1.Location = new System.Drawing.Point(214, 251);
            this.movieListBox1.Name = "movieListBox1";
            this.movieListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.movieListBox1.Size = new System.Drawing.Size(818, 355);
            this.movieListBox1.TabIndex = 0;
            this.movieListBox1.SelectedIndexChanged += new System.EventHandler(this.movieListBox1_SelectedIndexChanged);
            // 
            // selectRandomMovieButton
            // 
            this.selectRandomMovieButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectRandomMovieButton.Location = new System.Drawing.Point(207, 80);
            this.selectRandomMovieButton.Name = "selectRandomMovieButton";
            this.selectRandomMovieButton.Size = new System.Drawing.Size(125, 23);
            this.selectRandomMovieButton.TabIndex = 2;
            this.selectRandomMovieButton.Text = "Select Random Movie";
            this.selectRandomMovieButton.UseVisualStyleBackColor = true;
            this.selectRandomMovieButton.Click += new System.EventHandler(this.selectRandomMovieButton_Click);
            // 
            // addToWatchedButton
            // 
            this.addToWatchedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addToWatchedButton.Location = new System.Drawing.Point(566, 79);
            this.addToWatchedButton.Name = "addToWatchedButton";
            this.addToWatchedButton.Size = new System.Drawing.Size(143, 23);
            this.addToWatchedButton.TabIndex = 3;
            this.addToWatchedButton.Text = "Add to Watched";
            this.addToWatchedButton.UseVisualStyleBackColor = true;
            this.addToWatchedButton.Click += new System.EventHandler(this.addToWatchedButton_Click);
            // 
            // selectedMoviesListBox
            // 
            this.selectedMoviesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedMoviesListBox.FormattingEnabled = true;
            this.selectedMoviesListBox.Location = new System.Drawing.Point(554, 644);
            this.selectedMoviesListBox.Name = "selectedMoviesListBox";
            this.selectedMoviesListBox.Size = new System.Drawing.Size(120, 95);
            this.selectedMoviesListBox.TabIndex = 4;
            this.selectedMoviesListBox.SelectedIndexChanged += new System.EventHandler(this.movieListBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 799);
            this.Controls.Add(this.selectedMoviesListBox);
            this.Controls.Add(this.addToWatchedButton);
            this.Controls.Add(this.selectRandomMovieButton);
            this.Controls.Add(this.movieListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox movieListBox1;
        private System.Windows.Forms.Button selectRandomMovieButton;
        private System.Windows.Forms.Button addToWatchedButton;
        private System.Windows.Forms.ListBox selectedMoviesListBox;
    }
}

