﻿namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    partial class LikesStatisticsForm
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
            this.title = new System.Windows.Forms.Label();
            this.likesFromDate = new System.Windows.Forms.DateTimePicker();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.likesToDate = new System.Windows.Forms.DateTimePicker();
            this.checkLikesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Levenim MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.title.Location = new System.Drawing.Point(638, 59);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(765, 82);
            this.title.TabIndex = 0;
            this.title.Text = "Who Liked You the most?";
            // 
            // likesFromDate
            // 
            this.likesFromDate.CalendarFont = new System.Drawing.Font("Levenim MT", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.likesFromDate.Font = new System.Drawing.Font("Levenim MT", 15.9F);
            this.likesFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.likesFromDate.Location = new System.Drawing.Point(523, 157);
            this.likesFromDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.likesFromDate.Name = "likesFromDate";
            this.likesFromDate.Size = new System.Drawing.Size(404, 82);
            this.likesFromDate.TabIndex = 1;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Levenim MT", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fromLabel.Location = new System.Drawing.Point(363, 174);
            this.fromLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(140, 63);
            this.fromLabel.TabIndex = 2;
            this.fromLabel.Text = "From";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Levenim MT", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.toLabel.Location = new System.Drawing.Point(1026, 174);
            this.toLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(78, 63);
            this.toLabel.TabIndex = 3;
            this.toLabel.Text = "To";
            // 
            // likesToDate
            // 
            this.likesToDate.CalendarFont = new System.Drawing.Font("Levenim MT", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.likesToDate.Font = new System.Drawing.Font("Levenim MT", 15.9F);
            this.likesToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.likesToDate.Location = new System.Drawing.Point(1118, 160);
            this.likesToDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.likesToDate.Name = "likesToDate";
            this.likesToDate.Size = new System.Drawing.Size(406, 82);
            this.likesToDate.TabIndex = 4;
            // 
            // checkLikesButton
            // 
            this.checkLikesButton.Font = new System.Drawing.Font("Levenim MT", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkLikesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkLikesButton.Location = new System.Drawing.Point(752, 273);
            this.checkLikesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkLikesButton.Name = "checkLikesButton";
            this.checkLikesButton.Size = new System.Drawing.Size(617, 124);
            this.checkLikesButton.TabIndex = 5;
            this.checkLikesButton.Text = "Show me the results!";
            this.checkLikesButton.UseVisualStyleBackColor = true;
            this.checkLikesButton.Click += new System.EventHandler(this.checkLikesButton_Click);
            // 
            // LikesStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 916);
            this.Controls.Add(this.checkLikesButton);
            this.Controls.Add(this.likesToDate);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.likesFromDate);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "LikesStatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Likes Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DateTimePicker likesFromDate;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DateTimePicker likesToDate;
        private System.Windows.Forms.Button checkLikesButton;
    }
}