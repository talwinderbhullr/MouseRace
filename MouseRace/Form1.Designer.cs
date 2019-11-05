namespace MouseRace_Project
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
            this.btnBet = new System.Windows.Forms.Button();
            this.btnRace = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.tbxDiplo = new System.Windows.Forms.TextBox();
            this.tbxAnkylo = new System.Windows.Forms.TextBox();
            this.tbxArchaeo = new System.Windows.Forms.TextBox();
            this.lblDiplo = new System.Windows.Forms.Label();
            this.lblAnkylo = new System.Windows.Forms.Label();
            this.lblArchaeo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWinning = new System.Windows.Forms.Label();
            this.radDiplodocus = new System.Windows.Forms.RadioButton();
            this.radAnkylosaurus = new System.Windows.Forms.RadioButton();
            this.radArchaeopteryx = new System.Windows.Forms.RadioButton();
            this.udtBet = new System.Windows.Forms.NumericUpDown();
            this.udtMouse = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.radFake = new System.Windows.Forms.RadioButton();
            this.Jerry = new System.Windows.Forms.PictureBox();
            this.Slowpoke = new System.Windows.Forms.PictureBox();
            this.Speedy = new System.Windows.Forms.PictureBox();
            this.RaceTrack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.udtBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udtMouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jerry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slowpoke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speedy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaceTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.Color.Red;
            this.btnBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBet.Location = new System.Drawing.Point(269, 515);
            this.btnBet.Margin = new System.Windows.Forms.Padding(4);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(153, 63);
            this.btnBet.TabIndex = 0;
            this.btnBet.Text = "BET";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // btnRace
            // 
            this.btnRace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRace.Location = new System.Drawing.Point(803, 554);
            this.btnRace.Margin = new System.Windows.Forms.Padding(4);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(159, 59);
            this.btnRace.TabIndex = 1;
            this.btnRace.Text = "RACE";
            this.btnRace.UseVisualStyleBackColor = false;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Yellow;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestart.Location = new System.Drawing.Point(627, 554);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(152, 59);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "GO AGAIN";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // tbxDiplo
            // 
            this.tbxDiplo.Location = new System.Drawing.Point(395, 427);
            this.tbxDiplo.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDiplo.Name = "tbxDiplo";
            this.tbxDiplo.ReadOnly = true;
            this.tbxDiplo.Size = new System.Drawing.Size(565, 22);
            this.tbxDiplo.TabIndex = 8;
            // 
            // tbxAnkylo
            // 
            this.tbxAnkylo.Location = new System.Drawing.Point(395, 457);
            this.tbxAnkylo.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAnkylo.Name = "tbxAnkylo";
            this.tbxAnkylo.ReadOnly = true;
            this.tbxAnkylo.Size = new System.Drawing.Size(565, 22);
            this.tbxAnkylo.TabIndex = 9;
            // 
            // tbxArchaeo
            // 
            this.tbxArchaeo.Location = new System.Drawing.Point(395, 485);
            this.tbxArchaeo.Margin = new System.Windows.Forms.Padding(4);
            this.tbxArchaeo.Name = "tbxArchaeo";
            this.tbxArchaeo.ReadOnly = true;
            this.tbxArchaeo.Size = new System.Drawing.Size(565, 22);
            this.tbxArchaeo.TabIndex = 10;
            // 
            // lblDiplo
            // 
            this.lblDiplo.AutoSize = true;
            this.lblDiplo.Location = new System.Drawing.Point(167, 431);
            this.lblDiplo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiplo.Name = "lblDiplo";
            this.lblDiplo.Size = new System.Drawing.Size(46, 17);
            this.lblDiplo.TabIndex = 15;
            this.lblDiplo.Text = "label1";
            // 
            // lblAnkylo
            // 
            this.lblAnkylo.AutoSize = true;
            this.lblAnkylo.Location = new System.Drawing.Point(167, 461);
            this.lblAnkylo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnkylo.Name = "lblAnkylo";
            this.lblAnkylo.Size = new System.Drawing.Size(46, 17);
            this.lblAnkylo.TabIndex = 16;
            this.lblAnkylo.Text = "label2";
            // 
            // lblArchaeo
            // 
            this.lblArchaeo.AutoSize = true;
            this.lblArchaeo.Location = new System.Drawing.Point(167, 489);
            this.lblArchaeo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchaeo.Name = "lblArchaeo";
            this.lblArchaeo.Size = new System.Drawing.Size(46, 17);
            this.lblArchaeo.TabIndex = 17;
            this.lblArchaeo.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 400);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Punter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 532);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Bet Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 570);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "On Mouse #";
            // 
            // lblWinning
            // 
            this.lblWinning.AutoSize = true;
            this.lblWinning.Location = new System.Drawing.Point(799, 400);
            this.lblWinning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinning.Name = "lblWinning";
            this.lblWinning.Size = new System.Drawing.Size(105, 17);
            this.lblWinning.TabIndex = 21;
            this.lblWinning.Text = "Winning Mouse";
            // 
            // radDiplodocus
            // 
            this.radDiplodocus.AutoSize = true;
            this.radDiplodocus.Location = new System.Drawing.Point(28, 426);
            this.radDiplodocus.Margin = new System.Windows.Forms.Padding(4);
            this.radDiplodocus.Name = "radDiplodocus";
            this.radDiplodocus.Size = new System.Drawing.Size(99, 21);
            this.radDiplodocus.TabIndex = 22;
            this.radDiplodocus.TabStop = true;
            this.radDiplodocus.Text = "Diplodocus";
            this.radDiplodocus.UseVisualStyleBackColor = true;
            this.radDiplodocus.CheckedChanged += new System.EventHandler(this.RBAll_CheckedChanged);
            // 
            // radAnkylosaurus
            // 
            this.radAnkylosaurus.AutoSize = true;
            this.radAnkylosaurus.Location = new System.Drawing.Point(28, 456);
            this.radAnkylosaurus.Margin = new System.Windows.Forms.Padding(4);
            this.radAnkylosaurus.Name = "radAnkylosaurus";
            this.radAnkylosaurus.Size = new System.Drawing.Size(114, 21);
            this.radAnkylosaurus.TabIndex = 23;
            this.radAnkylosaurus.TabStop = true;
            this.radAnkylosaurus.Text = "Ankylosaurus";
            this.radAnkylosaurus.UseVisualStyleBackColor = true;
            this.radAnkylosaurus.CheckedChanged += new System.EventHandler(this.RBAll_CheckedChanged);
            // 
            // radArchaeopteryx
            // 
            this.radArchaeopteryx.AutoSize = true;
            this.radArchaeopteryx.Location = new System.Drawing.Point(28, 484);
            this.radArchaeopteryx.Margin = new System.Windows.Forms.Padding(4);
            this.radArchaeopteryx.Name = "radArchaeopteryx";
            this.radArchaeopteryx.Size = new System.Drawing.Size(120, 21);
            this.radArchaeopteryx.TabIndex = 24;
            this.radArchaeopteryx.TabStop = true;
            this.radArchaeopteryx.Text = "Archaeopteryx";
            this.radArchaeopteryx.UseVisualStyleBackColor = true;
            this.radArchaeopteryx.CheckedChanged += new System.EventHandler(this.RBAll_CheckedChanged);
            // 
            // udtBet
            // 
            this.udtBet.Location = new System.Drawing.Point(171, 532);
            this.udtBet.Margin = new System.Windows.Forms.Padding(4);
            this.udtBet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udtBet.Name = "udtBet";
            this.udtBet.ReadOnly = true;
            this.udtBet.Size = new System.Drawing.Size(59, 22);
            this.udtBet.TabIndex = 25;
            // 
            // udtMouse
            // 
            this.udtMouse.Location = new System.Drawing.Point(171, 570);
            this.udtMouse.Margin = new System.Windows.Forms.Padding(4);
            this.udtMouse.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.udtMouse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udtMouse.Name = "udtMouse";
            this.udtMouse.ReadOnly = true;
            this.udtMouse.Size = new System.Drawing.Size(59, 22);
            this.udtMouse.TabIndex = 26;
            this.udtMouse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mouse 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mouse 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 310);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Mouse 3";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(269, 588);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(153, 48);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "EXIT";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // radFake
            // 
            this.radFake.AutoSize = true;
            this.radFake.Location = new System.Drawing.Point(451, 574);
            this.radFake.Margin = new System.Windows.Forms.Padding(4);
            this.radFake.Name = "radFake";
            this.radFake.Size = new System.Drawing.Size(110, 21);
            this.radFake.TabIndex = 31;
            this.radFake.TabStop = true;
            this.radFake.Text = "radioButton1";
            this.radFake.UseVisualStyleBackColor = true;
            this.radFake.Visible = false;
            // 
            // Jerry
            // 
            this.Jerry.Image = global::MouseRace_Project.Properties.Resources.jerry2;
            this.Jerry.Location = new System.Drawing.Point(102, 272);
            this.Jerry.Margin = new System.Windows.Forms.Padding(4);
            this.Jerry.Name = "Jerry";
            this.Jerry.Size = new System.Drawing.Size(128, 90);
            this.Jerry.TabIndex = 14;
            this.Jerry.TabStop = false;
            // 
            // Slowpoke
            // 
            this.Slowpoke.Image = global::MouseRace_Project.Properties.Resources.slow;
            this.Slowpoke.Location = new System.Drawing.Point(102, 156);
            this.Slowpoke.Margin = new System.Windows.Forms.Padding(4);
            this.Slowpoke.Name = "Slowpoke";
            this.Slowpoke.Size = new System.Drawing.Size(128, 90);
            this.Slowpoke.TabIndex = 13;
            this.Slowpoke.TabStop = false;
            // 
            // Speedy
            // 
            this.Speedy.Image = global::MouseRace_Project.Properties.Resources.speedy;
            this.Speedy.Location = new System.Drawing.Point(102, 44);
            this.Speedy.Margin = new System.Windows.Forms.Padding(4);
            this.Speedy.Name = "Speedy";
            this.Speedy.Size = new System.Drawing.Size(128, 90);
            this.Speedy.TabIndex = 12;
            this.Speedy.TabStop = false;
            // 
            // RaceTrack
            // 
            this.RaceTrack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RaceTrack.Image = global::MouseRace_Project.Properties.Resources.Racetrack;
            this.RaceTrack.InitialImage = global::MouseRace_Project.Properties.Resources.Racetrack;
            this.RaceTrack.Location = new System.Drawing.Point(29, 15);
            this.RaceTrack.Margin = new System.Windows.Forms.Padding(2);
            this.RaceTrack.Name = "RaceTrack";
            this.RaceTrack.Size = new System.Drawing.Size(933, 374);
            this.RaceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RaceTrack.TabIndex = 11;
            this.RaceTrack.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 640);
            this.Controls.Add(this.radFake);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.udtMouse);
            this.Controls.Add(this.udtBet);
            this.Controls.Add(this.radArchaeopteryx);
            this.Controls.Add(this.radAnkylosaurus);
            this.Controls.Add(this.radDiplodocus);
            this.Controls.Add(this.lblWinning);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblArchaeo);
            this.Controls.Add(this.lblAnkylo);
            this.Controls.Add(this.lblDiplo);
            this.Controls.Add(this.Jerry);
            this.Controls.Add(this.Slowpoke);
            this.Controls.Add(this.Speedy);
            this.Controls.Add(this.RaceTrack);
            this.Controls.Add(this.tbxArchaeo);
            this.Controls.Add(this.tbxAnkylo);
            this.Controls.Add(this.tbxDiplo);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.btnBet);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Dinosaurs Bet on Mice Racing to the Beach";
            ((System.ComponentModel.ISupportInitialize)(this.udtBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udtMouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jerry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slowpoke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speedy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaceTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.TextBox tbxDiplo;
        private System.Windows.Forms.TextBox tbxAnkylo;
        private System.Windows.Forms.TextBox tbxArchaeo;
        private System.Windows.Forms.PictureBox RaceTrack;
        private System.Windows.Forms.PictureBox Speedy;
        private System.Windows.Forms.PictureBox Slowpoke;
        private System.Windows.Forms.PictureBox Jerry;
        private System.Windows.Forms.Label lblDiplo;
        private System.Windows.Forms.Label lblAnkylo;
        private System.Windows.Forms.Label lblArchaeo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWinning;
        private System.Windows.Forms.RadioButton radDiplodocus;
        private System.Windows.Forms.RadioButton radAnkylosaurus;
        private System.Windows.Forms.RadioButton radArchaeopteryx;
        private System.Windows.Forms.NumericUpDown udtBet;
        private System.Windows.Forms.NumericUpDown udtMouse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton radFake;
    }
}
