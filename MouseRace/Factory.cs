namespace MouseRace_Project
{
    public static class Factory
    {
        public static int DinoNumber { get; set; }

        public static void ChooseDino(string dinoName)
        {

            //using the name of the selected radiobutton a number is assigned to each dinosaur
            //this number is called DinoNumber and it is used by the RBAll_CheckedChanged method (which is used by all the radiobuttons) to place bets
            //The dinoNumber is the same as the location on the dinosaur in the myDino array

            switch (dinoName)
            {
                case "Diplodocus":
                    DinoNumber = 0;
                    break;

                case "Ankylosaurus":
                    DinoNumber = 1;
                    break;

                case "Archaeopteryx":
                    DinoNumber = 2;
                    break;
            }

        }

    }

}
