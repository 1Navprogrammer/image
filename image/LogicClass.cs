using Aspose.Cells.Drawing.Texts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace image
{
    class LogicClass
    {
        //this is the bullet
        public int Bullet;
        public int Score = 0;
        public int ShootingAwayChances = 2;


        public void Load()
        {
            Bullet = 0;
        }
        //Spin roller
        public void Spin()
        {
            Random rand = new Random();
            Bullet = rand.Next(0, 6);
        }
        //this function is Shoot a head

        public void Shootahead()
        {
            if (Bullet == 5)
            {
                MessageBox.Show("You win the game");
                Score = Score - 5;
            }
            else
            {
                MessageBox.Show("Continuous start playing");
                Bullet++;
            }
        }
        // this is ShootAway
        public void Shootaway()
        {
            ShootingAwayChances--;
            if (ShootingAwayChances == 0)
            {
                MessageBox.Show("You lost the Chance");
            }
            else
            {


                if (Bullet == 5)
                {
                    MessageBox.Show("You are lucky");
                    Score = Score + 5;
                }
                else
                {
                    MessageBox.Show("Continuous start playing");
                    Bullet++;
                }
            }
        }
    }
}
    

