namespace latihanCustomListFlyoutPanel
{
    partial class CustomListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomListItem));
            this.pic_movie = new System.Windows.Forms.PictureBox();
            this.lblJudulMovie = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOverview = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_movie)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_movie
            // 
            this.pic_movie.Location = new System.Drawing.Point(3, 3);
            this.pic_movie.Name = "pic_movie";
            this.pic_movie.Size = new System.Drawing.Size(94, 110);
            this.pic_movie.TabIndex = 0;
            this.pic_movie.TabStop = false;
            // 
            // lblJudulMovie
            // 
            this.lblJudulMovie.AutoSize = true;
            this.lblJudulMovie.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJudulMovie.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblJudulMovie.Location = new System.Drawing.Point(103, 3);
            this.lblJudulMovie.Name = "lblJudulMovie";
            this.lblJudulMovie.Size = new System.Drawing.Size(76, 26);
            this.lblJudulMovie.TabIndex = 1;
            this.lblJudulMovie.Text = "Ini Judul";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReleaseDate.Location = new System.Drawing.Point(454, 3);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(77, 23);
            this.lblReleaseDate.TabIndex = 2;
            this.lblReleaseDate.Text = "20/12/2022";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(103, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 2);
            this.panel1.TabIndex = 3;
            // 
            // lblOverview
            // 
            this.lblOverview.Location = new System.Drawing.Point(103, 35);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(369, 68);
            this.lblOverview.TabIndex = 4;
            this.lblOverview.Text = resources.GetString("lblOverview.Text");
            this.lblOverview.MouseEnter += new System.EventHandler(this.lblOverview_MouseEnter);
            this.lblOverview.MouseLeave += new System.EventHandler(this.lblOverview_MouseLeave);
            this.lblOverview.MouseHover += new System.EventHandler(this.lblOverview_MouseHover);
            // 
            // CustomListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblOverview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblJudulMovie);
            this.Controls.Add(this.pic_movie);
            this.Name = "CustomListItem";
            this.Size = new System.Drawing.Size(534, 116);
            this.Load += new System.EventHandler(this.CustomListItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_movie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pic_movie;
        private Label lblJudulMovie;
        private Label lblReleaseDate;
        private Panel panel1;
        private Label lblOverview;
    }
}
