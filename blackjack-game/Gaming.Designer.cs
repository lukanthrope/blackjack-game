namespace blackjack_game
{
    partial class Gaming
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gaming));
            this.pictureClim = new System.Windows.Forms.PictureBox();
            this.pictureGoblin = new System.Windows.Forms.PictureBox();
            this.pictureCrupie = new System.Windows.Forms.PictureBox();
            this.pictureTable = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGoblin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCrupie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureClim
            // 
            this.pictureClim.Image = ((System.Drawing.Image)(resources.GetObject("pictureClim.Image")));
            this.pictureClim.Location = new System.Drawing.Point(1001, 163);
            this.pictureClim.Name = "pictureClim";
            this.pictureClim.Size = new System.Drawing.Size(290, 277);
            this.pictureClim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClim.TabIndex = 7;
            this.pictureClim.TabStop = false;
            // 
            // pictureGoblin
            // 
            this.pictureGoblin.Image = ((System.Drawing.Image)(resources.GetObject("pictureGoblin.Image")));
            this.pictureGoblin.Location = new System.Drawing.Point(271, 133);
            this.pictureGoblin.Name = "pictureGoblin";
            this.pictureGoblin.Size = new System.Drawing.Size(292, 322);
            this.pictureGoblin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureGoblin.TabIndex = 6;
            this.pictureGoblin.TabStop = false;
            // 
            // pictureCrupie
            // 
            this.pictureCrupie.Image = ((System.Drawing.Image)(resources.GetObject("pictureCrupie.Image")));
            this.pictureCrupie.Location = new System.Drawing.Point(641, 22);
            this.pictureCrupie.Name = "pictureCrupie";
            this.pictureCrupie.Size = new System.Drawing.Size(207, 308);
            this.pictureCrupie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCrupie.TabIndex = 5;
            this.pictureCrupie.TabStop = false;
            // 
            // pictureTable
            // 
            this.pictureTable.Image = ((System.Drawing.Image)(resources.GetObject("pictureTable.Image")));
            this.pictureTable.Location = new System.Drawing.Point(291, -15);
            this.pictureTable.Name = "pictureTable";
            this.pictureTable.Size = new System.Drawing.Size(906, 791);
            this.pictureTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureTable.TabIndex = 4;
            this.pictureTable.TabStop = false;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(30, 54);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(46, 17);
            this.username.TabIndex = 8;
            this.username.Text = "label1";
            // 
            // Gaming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 788);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pictureClim);
            this.Controls.Add(this.pictureGoblin);
            this.Controls.Add(this.pictureCrupie);
            this.Controls.Add(this.pictureTable);
            this.Name = "Gaming";
            this.Text = "Gaming";
            this.Load += new System.EventHandler(this.Gaming_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureClim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGoblin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCrupie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureClim;
        private System.Windows.Forms.PictureBox pictureGoblin;
        private System.Windows.Forms.PictureBox pictureCrupie;
        private System.Windows.Forms.PictureBox pictureTable;
        private System.Windows.Forms.Label username;
    }
}