
namespace AnimalRosterManagerApp
{
    public class Animal
    {
        //Class fields
        private string gender;      //Gender of animal

        private DietTypes dietType; //The animal's type of diet

        private int age;          //Age of animal


        /**
         *Default constructor of the Animal class.
         */
        public Animal()
        {

        }

        //Class properties

        public string Name { get; set; }

        //Type of animal
        public string Type { get; set; }

        //Gender of animal
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (value.ToLower() == "male" || value.ToLower() == "female")
                {
                    gender = value;
                }
            }
        }

        public enum DietTypes
        {
            Omnivore,
            Herbivore,
            Carnivore
        }

        //Diet of animal
        public string DietType
        {
            get
            {
                switch (dietType)
                {
                    case DietTypes.Omnivore:
                        return "Omnivore";
                    case DietTypes.Herbivore:
                        return "Herbivore";
                    case DietTypes.Carnivore:
                        return "Carnivore";
                    default:
                        return "an undefined type of eater";
                }
            }
            set
            {
                switch (value.ToLower())
                {
                    case "omnivore":
                        dietType = DietTypes.Omnivore;
                        break;
                    case "herbivore":
                        dietType = DietTypes.Herbivore;
                        break;
                    case "carnivore":
                        dietType = DietTypes.Carnivore;
                        break;
                    default:
                        break;
                }
            }
        }

        //Location where animal lives in zoo
        public string ZooLocation { get; set; }

        //Age of animal
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
            }
        }

        public string HowTheAnimalMoves { get; set; }

        public override string ToString()
        {
            string theirGenderPronoun,                  //The gender pronoun to use
                   animalInfo = "";                     //String of info to return

            //Finds out the animal's gender pronoun
            theirGenderPronoun = Gender.ToLower() == "male" ? "He" : "She";

            //Creates the formatted string of the info to return
            animalInfo += string.Format("This is our {0} year old {1}.  ", Age, Type.ToLower());

            animalInfo += string.Format("{0} lives here at {1}.  ", theirGenderPronoun, ZooLocation);

            animalInfo += string.Format("{0} is a {1}.  ", theirGenderPronoun, DietType.ToLower());

            animalInfo += HowTheAnimalMoves;

            return animalInfo;
        }
    }
}
