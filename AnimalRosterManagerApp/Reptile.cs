
namespace AnimalRosterManagerApp
{
    public class Reptile : Animal
    {
        /**
         * Default constructor
         */
        public Reptile() : base()
        {

        }

        //Class properties
        public bool HasAShell { get; set; }
        public bool LivesIndoors { get; set; }


        /**
         * Prints out all the info on a reptile in a formatted matter.
         * @return The info about a reptile
         */
        public override string ToString()
        {
            string theirGenderPronoun,                  //The gender pronoun to use
                   theirDietType = DietType.ToLower(),  //The reptile's diet type
                   animalInfo = "";                     //The string to return with the reptile's info

            //Finds out the reptile's gender pronoun
            if (Gender.ToLower() == "male") //Is a male
            {
                theirGenderPronoun = "He";
            }
            else //Is a female
            {
                theirGenderPronoun = "She";
            }

            if (DietType == "omnivore")
            {
                theirDietType = "an " + theirDietType;
            }
            else
            {
                theirDietType = "a " + theirDietType;
            }

            //Creates the formatted string of the info to return
            animalInfo += string.Format("This is our {0} year old {1}.  ",
                            Age, Type.ToLower());

            animalInfo += string.Format("{0} lives {1} at {2}.  ",
                           theirGenderPronoun, (LivesIndoors ? "indoors" : "outdoors"), ZooLocation);

            animalInfo += string.Format("{0} is {1}shelled and is {2}.  ",
                            theirGenderPronoun, (HasAShell ? "" : "not "), theirDietType);

            animalInfo += HowTheAnimalMoves;

            return animalInfo;
        }

        public static bool ConvertYesNoIntoBool(string yesNoAnswer)
        {
            yesNoAnswer = yesNoAnswer.ToLower();

            if(yesNoAnswer == "yes")
            {
                return true;
            }

            return false; //yesNoAnswer == "no"
        }

        public static string ConvertBoolIntoYesNo(bool trueOrFalse)
        {
            if(trueOrFalse) //trueOrFalse == true;
            {
                return "Yes";
            }

            return "No"; //trueOrFalse == false;
        }
    }
}
