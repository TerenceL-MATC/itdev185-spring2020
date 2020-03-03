using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRosterManagerApp
{
    public class Bird : Animal
    {
        /**
         * Default constructor
         */
        public Bird() : base()
        {

        }

        //Class properties
        public bool IsTagged { get; set; }

        /**
        * Prints out all the info about a bird in a formatted matter
        * @return The info about a bird at the zoo
        */
        public override string ToString()
        {
            string theirGenderPronoun,                  //The gender pronoun to use
                   aboutTheirDiet = "  ",               //Holds info about the birds' diet
                   animalInfo = "";                     //String of info to return

            //Finds out the bird's gender pronoun
            if (Gender.ToLower() == "male") //Is a male
            {
                theirGenderPronoun = "He";
            }
            else //Is a female
            {
                theirGenderPronoun = "She";
            }

            //Determines how to format their diet info.
            if (DietType == "Omnivore") //Not a carnivore
            {
                aboutTheirDiet = "  They\'re an omnivore.  ";
            }
            else if (DietType == "Herbivore")
            {
                aboutTheirDiet = "  They\'re a herbivore.  ";
            }


            //Creates the formatted string of the info to return
            animalInfo += string.Format("This is our {0} year old {1}.  ",
                            Age, Type.ToLower());

            animalInfo += string.Format("{0} is{1} tagged and lives here at {2}.  ",
                            theirGenderPronoun, (IsTagged ? "" : "n\'t"), ZooLocation);

            animalInfo += string.Format("{0} is{1} a carnivore.{2}",
                            theirGenderPronoun, (aboutTheirDiet == "" ? "" : "n\'t"), aboutTheirDiet);

            animalInfo += HowTheAnimalMoves;

            return animalInfo;
        }
    }
}
