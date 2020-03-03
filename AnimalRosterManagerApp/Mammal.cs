using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRosterManagerApp
{
    public class Mammal : Animal
    {
        //Class fields
        private double weight;      //Weight of mammal
        private int dailyMealCount; //How many meals per day does the mammal eat?

        /**
         * Default constructor
         */
        public Mammal() : base()
        {

        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0.0)
                {
                    weight = value;
                }
            }
        }

        public int DailyMealCount
        {
            get
            {
                return dailyMealCount;
            }
            set
            {
                if (value > 0)
                {
                    dailyMealCount = value;
                }
            }
        }

        /**
         * Prints out all the info of the mammal in a formatted matter.
         * @return The info of the mammal
         */
        public override string ToString()
        {
            string theirGenderPronoun,
                   animalInfo = "";

            //Finds out the mammal's gender pronoun
            if (Gender.ToLower() == "male") //Is a male
            {
                theirGenderPronoun = "He";
            }
            else //Is a female
            {
                theirGenderPronoun = "She";
            }

            //Creates the formatted string of the info to return
            animalInfo += string.Format("This is one of our {0}s.  ",
                            Type.ToLower());

            animalInfo += string.Format("{0}\'s {1} years old and weighs {2:N1} pounds.  ",
                            theirGenderPronoun, Age, Weight);

            animalInfo += string.Format("{0} lives here at {1}, where {2} eats {3} {4} meals per day.  ",
                            theirGenderPronoun, ZooLocation, theirGenderPronoun.ToLower(), DailyMealCount, DietType.ToLower());

            animalInfo += HowTheAnimalMoves;

            return animalInfo;
        }
    }
}
