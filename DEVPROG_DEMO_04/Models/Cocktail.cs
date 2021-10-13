using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVPROG_DEMO_04.Models
{
    public class Cocktail : Drink
    {
        //object composition : a cocktail consist of a mix of other drinks
        public List<Drink> Ingredients { get; set; }

        //abstract properties in base class MUST be overriden 
        public override string Sign => "C";//automatically generated lambda expression
        //public override string Sign { get { return "C"; } } //alternative for lambda expression

        public override string Description
        {
            get
            {   //show list of ingredients
                string description = "";
                foreach (Drink drink in Ingredients)
                    description += drink + ", ";

                return description;
            }
        }

    }
}
