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
        public int ShootaheadChances = 5;

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
                MessageBox.Show("You lost");
                Score = Score - 5;
            }
            else
            {
                MessageBox.Show("continue playing");
                Bullet++;
            }
        }
        // this is ShootAway
        public void Shootaway()
        {
            ShootingAwayChances--;
            if (ShootingAwayChances == 0)
            {
                MessageBox.Show("You lost the Chances and you lose");
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
                    MessageBox.Show("continue playing");
                    Bullet++;
                }
            }
        }
         
    }
}
    

