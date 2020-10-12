using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVPROG_DEMO_04.Model
{
    public class Beer : Drink   //automatically implement class using 'lightbulb' quick actions
    {
        //extra variables
        public bool IsDraughtBeer { get; set; } //van 't vat
        public bool IsFruitBeer { get; set; }
        public double Alcohol { get; set; }
       
        //these variables are abstract in base class and MUST be overriden
        public override string Sign => "B";     //automatically generated lambda expression
        //public override string Sign { get { return "B"; } } //alternative for lambda expression

        public override string Description
        {
            get
            {
                string description = Alcohol + "%";
                //if the is is a fruit beer, this should be added in the description
                //  otherwise, just show alcohol percentage
                if (IsFruitBeer)
                    description = "fruit beer, " + description;
                return description;
            }
        }

        //Name property is virtual in the baseclass and therefore CAN be overriden
        public override string Name
        {
            get
            {   
                //show the name of the beer (= base class), preceded by the type (bottled/draught)
                string prefix = "BOTTLED: ";
                if (IsDraughtBeer)
                    prefix = "DRAUGHT BEER: ";
                return prefix + base.Name;  //base.Name prefers tot the getter of the base class for Name property
            }
            set => base.Name = value;   //automatically generated lambda expression
        }

        //this method is virtual in base class and therefor CAN be overriden
        public override void ShowServingInstructions()
        {            
            if (!IsDraughtBeer)
            {
                //show base instructions, ADDED by one other instruction
                base.ShowServingInstructions();
                Debug.WriteLine("* remove excessive foam using a knife");
            }
            else
            {
                //REPLACE the base instructions by these
                Debug.WriteLine("This is how you serve " + this.Name + ":");
                Debug.WriteLine("* tap draught beer in glass");
            }
        }
    }
}
