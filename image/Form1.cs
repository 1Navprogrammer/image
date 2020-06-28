using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image
{

    public partial class  Form1 : Form
    { 
        

        LogicClass Logic = new LogicClass();

        public object Shootahead { get; private set; }

        public Form1()
            
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Load.Enabled = true;
            Spin.Enabled = false;
            Gunsound.Enabled = false;
            Gunsound2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logic.Shootahead();
            PlayAgain.Enabled = true;
            textBox1.Text = Logic.Score + "";
            SoundPlayer player = new SoundPlayer(Resource1.GunSound);
            player.Play();

        }

        private void Gunsound2_Click(object sender, EventArgs e)
        {
           if (Logic.ShootingAwayChances == 0)
            {
                Gunsound2.Enabled = false;
                PlayAgain.Enabled = true;
            }
            Logic.Shootaway(); 
            SoundPlayer player = new SoundPlayer(Resource1.Gunsound2);
            player.Play();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            Logic.Load();
            Load.Enabled = false; 
            Spin.Enabled = true;
           Gunsound.Enabled = false;
            Gunsound2.Enabled = false;
            PlayAgain.Enabled = false;
            SoundPlayer player = new SoundPlayer(Resource1.Load);
            player.Play();
        }

        private void Spin_Click(object sender, EventArgs e)
        {
            Logic.Spin();
            Logic.Load();
            Load.Enabled = false;
            Spin.Enabled = false;
            Gunsound.Enabled = true;
            Gunsound2.Enabled = true;
            PlayAgain.Enabled = false;
            SoundPlayer player = new SoundPlayer(Resource1.Spin);
            player.Play();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            Logic.Load();
            Load.Enabled = true; 
            Spin.Enabled = false;
            Gunsound.Enabled = false;
            Gunsound2.Enabled = false;
        }
    }
}
 