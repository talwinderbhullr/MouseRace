using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseRace_Project
{
    class Mouse
        {
           //each mouse is represented by a picturebox which is manipulated for the race

         public  PictureBox mypb = new PictureBox();

          //the only thing what seperates each mouse is its name
         public  string Name { get; set; }

        }
}
