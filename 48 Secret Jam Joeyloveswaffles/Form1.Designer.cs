namespace _48_Secret_Jam_Joeyloveswaffles
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.flanders_button = new System.Windows.Forms.Button();
            this.flanders_greeted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(9, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(150, 17);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Time Left: 20 Seconds";
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // flanders_button
            // 
            this.flanders_button.BackColor = System.Drawing.Color.White;
            this.flanders_button.BackgroundImage = global::_48_Secret_Jam_Joeyloveswaffles.Properties.Resources.Ned_Flanders;
            this.flanders_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flanders_button.ForeColor = System.Drawing.Color.White;
            this.flanders_button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flanders_button.Location = new System.Drawing.Point(12, 43);
            this.flanders_button.Name = "flanders_button";
            this.flanders_button.Size = new System.Drawing.Size(150, 200);
            this.flanders_button.TabIndex = 4;
            this.flanders_button.UseVisualStyleBackColor = false;
            this.flanders_button.Click += new System.EventHandler(this.flanders_button_Click);
            // 
            // flanders_greeted
            // 
            this.flanders_greeted.AutoSize = true;
            this.flanders_greeted.Location = new System.Drawing.Point(209, 9);
            this.flanders_greeted.Name = "flanders_greeted";
            this.flanders_greeted.Size = new System.Drawing.Size(132, 17);
            this.flanders_greeted.TabIndex = 5;
            this.flanders_greeted.Text = "Flanders Shooed: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::_48_Secret_Jam_Joeyloveswaffles.Properties.Resources.Simpsons_Door;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.flanders_greeted);
            this.Controls.Add(this.flanders_button);
            this.Controls.Add(this.timeLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neighbor Greeter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button flanders_button;
        private System.Windows.Forms.Label flanders_greeted;
    }
}

