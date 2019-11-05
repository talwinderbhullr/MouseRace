using System;
using System.Windows.Forms;

namespace MouseRace_Project
{
    public partial class Form1 : Form
    {
        //setting the dinosaur and mouse arrays
        //and the important int winningmouse

        private Dinosaur[] myDino = new Dinosaur[3];
        Mouse[] myMouse = new Mouse[3];
        private int winningmouse;

        public Form1()
        {
            InitializeComponent();
            btnRestart.Enabled = false;


            //each dinosaur has a set place in the array
            myDino[0] = new Diplodocus();
            myDino[1] = new Ankylosaurus();
            myDino[2] = new Archaeopteryx();
            //when the program load each dinosaur has a set about of cash
            myDino[0].Cash = 50;
            myDino[1].Cash = 50;
            myDino[2].Cash = 50;

            //labels, radiobuttons, and text boxs are assigned to each dinosaur in the array
            myDino[0].myLabel = lblDiplo;
            myDino[1].myLabel = lblAnkylo;
            myDino[2].myLabel = lblArchaeo;

            myDino[0].myRadioButton = radDiplodocus;
            myDino[1].myRadioButton = radAnkylosaurus;
            myDino[2].myRadioButton = radArchaeopteryx;

            myDino[0].MyBox = tbxDiplo;
            myDino[1].MyBox = tbxAnkylo;
            myDino[2].MyBox = tbxArchaeo;

            //each dinosaurs cash is shown when the game is loaded
            lblDiplo.Text = " Cash = " + myDino[0].Cash;
            lblAnkylo.Text = " Cash = " + myDino[1].Cash;
            lblArchaeo.Text = " Cash = " + myDino[2].Cash;

        }

        private NumericUpDown fakeNumericUpDown = new NumericUpDown();

        private Random myRandom = new Random();


        public void btnRace_Click(object sender, EventArgs e)
        {
            //if you try to race before everyone has bet a message box pops up

            if (myDino[0].betAmount == 0 || myDino[1].betAmount == 0 || myDino[2].betAmount == 0)
            {
                MessageBox.Show("All Dinosaurs Must Bet!");
                return;

            }


            //while the race is occuring the race, bet and restart buttons are disabled
            btnRace.Enabled = false;
            btnBet.Enabled = false;
            btnRestart.Enabled = false;
            udtBet.Enabled = false;
            udtMouse.Enabled = false;

            //placeing the mice in at array in a set order


            myMouse[0] = new Mouse() { Name = "Speedy (Mouse 1)", mypb = Speedy };
            myMouse[1] = new Mouse() { Name = "Slowpoke (Mouse 2)", mypb = Slowpoke };
            myMouse[2] = new Mouse() { Name = "Jerry (Mouse 3)", mypb = Jerry };

            bool everyoneFinished = false;


            //while everyone has not finished this loop repeats
            //a random number is added to the X axis of the mouse picture boxes
            //when the loop ends the winning mouse is declared and sent out
            while (!everyoneFinished)
            {

                for (int i = 0; i < 3; i++)
                {

                    myMouse[i].mypb.Left += (myRandom.Next(1, 30));


                    if (myMouse[i].mypb.Left > 585)
                    {
                        everyoneFinished = true;
                        lblWinning.Text = myMouse[i].Name + " Wins!";
                        winningmouse = i + 1;
                        Application.DoEvents();
                    }
                    System.Threading.Thread.Sleep(50);

                }
            }
            //since the race is over the bets are calculated
            CalculateBets(everyoneFinished);

            //after the car has ended the restart button is reenabled
            btnRestart.Enabled = true;


            //if everyone has no cash the game is over
            if ((myDino[0].Cash < 1) && (myDino[1].Cash < 1) && (myDino[2].Cash < 1))
            {
                this.Text = "GAME OVER";
                btnBet.Enabled = false;
                btnRace.Enabled = false;
                btnRestart.Enabled = false;
                udtBet.Enabled = false;
                udtMouse.Enabled = false;

            }

        }


        public void RBAll_CheckedChanged(object sender, EventArgs e)
        {

            //using the factory class to switch which dinosaur class is choosing its bets and mouse
            //this allows each dinosaur to choose its bet amount and mouse seperately even while using shared buttons
            //this method is assigned to each dinosaurs radio button
            RadioButton FakeRB = new RadioButton();

            FakeRB = (RadioButton)sender;

            if (FakeRB.Checked)
            {
                //when a radio button is clicked the dinoNumber is chosen by the factory reading the name on their radio button
                //using the choosesomething method from the factory class
                //the dinosaurs cash is checked, for convenience, the bet up/down buttons value is set to the amount of cash the dino has

                //the factory switch method is called. FakeRB.Text is sent.
                Factory.ChooseDino(FakeRB.Text);

                udtBet.Maximum = myDino[Factory.DinoNumber].Cash;
                udtBet.Value = udtBet.Maximum;
            }
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            //for each factory.dinonumber 0,1,2
            //the dinosaur selects the mouse and bet value
            //the bet and mouse values are sent to an array and as a string to textboxes and labels

            myDino[Factory.DinoNumber].betAmount = Convert.ToInt16(udtBet.Value);
            myDino[Factory.DinoNumber].MouseNumber = Convert.ToInt16(udtMouse.Value);
            myDino[Factory.DinoNumber].myLabel.Text = "Betting on mouse number: " + udtMouse.Value;
            myDino[Factory.DinoNumber].MyBox.Text = " Bet Amount $" + Convert.ToString(myDino[Factory.DinoNumber].betAmount) + " Maximum Bet $" + Convert.ToString(myDino[Factory.DinoNumber].Cash);
        }

        public void CalculateBets(bool everyoneFinished)
        {
            //this void calculates winnings and shows them in labels and text boxes
            //it is called by the race button
            if (everyoneFinished)
            {
                //once the race is over
                //winnings and losses of each dinosaur are calculated and shown

                for (int z = 0; z < 3; z++)
                {
                    bool isInGame = myDino[z].Cash > 0;
                    if (!isInGame)
                    {
                        continue;
                    }

                    if (winningmouse == myDino[z].MouseNumber)
                    {
                        myDino[z].Cash = myDino[z].Cash + myDino[z].betAmount;
                        myDino[z].MyBox.Text = "Wins $" + myDino[z].betAmount + "  Cash is now $" + (myDino[z].Cash);
                    }

                    if (winningmouse != myDino[z].MouseNumber)
                    {
                        myDino[z].Cash = myDino[z].Cash - myDino[z].betAmount;
                        myDino[z].MyBox.Text = "Cash Loss Of $" + myDino[z].betAmount + "  Cash is now $" + myDino[z].Cash;
                    }
                }

                //if any dinosaur has no money after the race their properties are greyed out
                for (int j = 0; j < 3; j++)
                {
                    if (myDino[j].Cash < 1)
                    {
                        myDino[j].MyBox.Text = "OUT";
                        myDino[j].MyBox.Enabled = false;
                        myDino[j].myLabel.Text = "OUT";
                        myDino[j].myLabel.Enabled = false;
                        myDino[j].myRadioButton.Enabled = false;
                        myDino[j].MouseNumber = 4;
                        myDino[j].betAmount = 1;

                    }
                }
            }
        }

        public void btnRestart_Click(object sender, EventArgs e)
        {
            //once the restart button has been clicked the button is disabled

            btnRestart.Enabled = false;
            //at the start of a new race the amount of cash each dinosaur has is shown on a label
            //and the mice are moved to the start of the track
            for (int j = 0; j < 3; j++)
            {
                if (myDino[j].Cash > 0)
                {
                    myDino[j].betAmount = 0;
                }

                myDino[j].myLabel.Text = "Cash  $" + Convert.ToString(myDino[j].Cash);
                myMouse[j].mypb.Left = 44;
            }

            //clears the last winner from the label so there is no old info
            lblWinning.Text = "";

            //this invisible radio button is checked at every race restart to avoid an error
            radFake.Checked = true;

            //pressing the restart button enables the race, bet and 'up/down' buttons. they were disabled during the race.
            btnBet.Enabled = true;
            btnRace.Enabled = true;
            udtBet.Enabled = true;
            udtMouse.Enabled = true;
        }

        //this button closes the game
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
