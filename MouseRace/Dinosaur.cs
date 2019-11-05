using System.Windows.Forms;


namespace MouseRace_Project
{
    public abstract class Dinosaur
    {

        public string Name { get; set; }
        public int Cash { get; set; }
        public int betAmount { get; set; }

        public int MouseNumber;
        public RadioButton myRadioButton { get; set; }
        public Label myLabel { get; set; }

        public TextBox MyBox { get; set; }

    }



    public class Ankylosaurus : Dinosaur
    {

        public Ankylosaurus()
        {

            Name = "Ankylosaurus";

        }
    }

    class Archaeopteryx : Dinosaur
    {
        public Archaeopteryx()
        {

            Name = "Archaeopteryx";
        }
    }

    class Diplodocus : Dinosaur
    {
        public Diplodocus()
        {

            Name = "Diplodocus";
        }
    }
}
