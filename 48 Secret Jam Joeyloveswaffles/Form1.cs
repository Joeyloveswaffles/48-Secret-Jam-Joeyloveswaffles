using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _48_Secret_Jam_Joeyloveswaffles
{
    public partial class Form1 : Form
    {
        // This integer variable keeps track of the remaining time.
        int timeLeft = 20;
        Random random = new Random();
        int randomXNumber;
        int randomYNumber;
        int timeWaited;
        int greetAmount = 0;

        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\Joeyl\OneDrive\Documents\Visual Studio 2015\Projects\48 Secret Jam Joeyloveswaffles\48 Secret Jam Joeyloveswaffles\Resources\HidleyHo.wav");

        public Form1()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        
        public void randomScreenLocation()
        {
            randomXNumber = random.Next(100, 1300);
            randomYNumber = random.Next(100, 650);
            timeWaited = random.Next(0, 7);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 1)
            {
                // Display the new time left by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = "Time Left: " + timeLeft + " Seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
            }
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {
          
        }

        private void flanders_button_Click(object sender, EventArgs e)
        {
            randomScreenLocation();
            if (timeLeft > 1)
            {
                greetAmount += 1;
                flanders_greeted.Text = "Flanders Shooed: " + greetAmount;
                flanders_button.Location = new Point(randomXNumber, randomYNumber);
            }
            if (timeLeft == 20)
            {
             //Start the timer.
                timeLeft = 20;
                timeLabel.Text = "Time Left: 20 Seconds";
                timer1.Start();
            }
            startSoundPlayer.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeLeft = 20;
            timeLabel.Text = "Time Left: 20 Seconds";
            greetAmount = 0;
            flanders_greeted.Text = "Flanders Shooed: 0";

        }
    }
}
