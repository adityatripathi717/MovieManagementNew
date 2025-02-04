namespace MovieManagement
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            txtMovieID = new TextBox();
            txtMovieTitle = new TextBox();
            txtMovieDirector = new TextBox();
            btnAddMovie = new Button();
            btnUpdateMovie = new Button();
            btnDeleteMovie = new Button();
            btnSaveMovies = new Button();
            btnLoadMovies = new Button();
            label6 = new Label();
            btnViewAllMovies = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 45);
            label1.Name = "label1";
            label1.Size = new Size(135, 38);
            label1.TabIndex = 0;
            label1.Text = "MOVIEID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 109);
            label2.Name = "label2";
            label2.Size = new Size(87, 38);
            label2.TabIndex = 1;
            label2.Text = "TITLE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 170);
            label3.Name = "label3";
            label3.Size = new Size(107, 38);
            label3.TabIndex = 2;
            label3.Text = "GENRE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 240);
            label4.Name = "label4";
            label4.Size = new Size(209, 38);
            label4.TabIndex = 3;
            label4.Text = "RELEASE DATE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 313);
            label5.Name = "label5";
            label5.Size = new Size(153, 38);
            label5.TabIndex = 4;
            label5.Text = "DIRECTOR";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(292, 175);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 33);
            comboBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(292, 247);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(201, 31);
            dateTimePicker1.TabIndex = 6;
            // 
            // txtMovieID
            // 
            txtMovieID.Location = new Point(292, 45);
            txtMovieID.Name = "txtMovieID";
            txtMovieID.Size = new Size(201, 31);
            txtMovieID.TabIndex = 7;
            // 
            // txtMovieTitle
            // 
            txtMovieTitle.Location = new Point(292, 109);
            txtMovieTitle.Name = "txtMovieTitle";
            txtMovieTitle.Size = new Size(201, 31);
            txtMovieTitle.TabIndex = 8;
            // 
            // txtMovieDirector
            // 
            txtMovieDirector.Location = new Point(292, 321);
            txtMovieDirector.Name = "txtMovieDirector";
            txtMovieDirector.Size = new Size(201, 31);
            txtMovieDirector.TabIndex = 9;
            // 
            // btnAddMovie
            // 
            btnAddMovie.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddMovie.Location = new Point(44, 383);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(112, 34);
            btnAddMovie.TabIndex = 10;
            btnAddMovie.Text = "ADD";
            btnAddMovie.UseVisualStyleBackColor = true;
            btnAddMovie.Click += btnAddMovie_Click;
            // 
            // btnUpdateMovie
            // 
            btnUpdateMovie.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUpdateMovie.Location = new Point(189, 383);
            btnUpdateMovie.Name = "btnUpdateMovie";
            btnUpdateMovie.Size = new Size(112, 34);
            btnUpdateMovie.TabIndex = 11;
            btnUpdateMovie.Text = "UPDATE";
            btnUpdateMovie.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMovie
            // 
            btnDeleteMovie.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDeleteMovie.Location = new Point(333, 383);
            btnDeleteMovie.Name = "btnDeleteMovie";
            btnDeleteMovie.Size = new Size(112, 34);
            btnDeleteMovie.TabIndex = 12;
            btnDeleteMovie.Text = "DELETE";
            btnDeleteMovie.UseVisualStyleBackColor = true;
            // 
            // btnSaveMovies
            // 
            btnSaveMovies.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSaveMovies.Location = new Point(474, 383);
            btnSaveMovies.Name = "btnSaveMovies";
            btnSaveMovies.Size = new Size(112, 34);
            btnSaveMovies.TabIndex = 13;
            btnSaveMovies.Text = "SAVE";
            btnSaveMovies.UseVisualStyleBackColor = true;
            // 
            // btnLoadMovies
            // 
            btnLoadMovies.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLoadMovies.Location = new Point(622, 383);
            btnLoadMovies.Name = "btnLoadMovies";
            btnLoadMovies.Size = new Size(112, 34);
            btnLoadMovies.TabIndex = 14;
            btnLoadMovies.Text = "LOAD";
            btnLoadMovies.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(121, -3);
            label6.Name = "label6";
            label6.Size = new Size(579, 48);
            label6.TabIndex = 15;
            label6.Text = "MOVIE MANAGEMENT SYSTEM";
            // 
            // btnViewAllMovies
            // 
            btnViewAllMovies.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnViewAllMovies.Location = new Point(622, 321);
            btnViewAllMovies.Name = "btnViewAllMovies";
            btnViewAllMovies.Size = new Size(112, 34);
            btnViewAllMovies.TabIndex = 16;
            btnViewAllMovies.Text = "View All";
            btnViewAllMovies.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(511, 48);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(277, 254);
            listBox1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(btnViewAllMovies);
            Controls.Add(label6);
            Controls.Add(btnLoadMovies);
            Controls.Add(btnSaveMovies);
            Controls.Add(btnDeleteMovie);
            Controls.Add(btnUpdateMovie);
            Controls.Add(btnAddMovie);
            Controls.Add(txtMovieDirector);
            Controls.Add(txtMovieTitle);
            Controls.Add(txtMovieID);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox txtMovieID;
        private TextBox txtMovieTitle;
        private TextBox txtMovieDirector;
        private Button btnAddMovie;
        private Button btnUpdateMovie;
        private Button btnDeleteMovie;
        private Button btnSaveMovies;
        private Button btnLoadMovies;
        private Label label6;
        private Button btnViewAllMovies;
        private ListBox listBox1;
    }
}
