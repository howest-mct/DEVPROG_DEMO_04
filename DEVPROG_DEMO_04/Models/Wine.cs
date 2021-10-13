using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEVPROG_DEMO_04.Interfaces;


namespace DEVPROG_DEMO_04.Models
{
    public enum WineType
    {
        RED,
        WHITE,
        ROSÉ,
        SPARKLING
    }

    public class Wine : Drink, ICollectable     //automatically implement using 'lightbulb' quick actions
    {
        //IMPLEMENTING the ICollectable interface
        public int YearOfOrigin { get; set; }

        //extra variables
        public string Country { get; set; }
        public List<string> Grapes { get; set; }
        public double PricePerBottle { get; set; }
        public WineType Type { get; set; }

        //virtual variables: automatically inherited but CAN be easily override        
        public override string PriceDisplay
        {
            //for wine, show the default price (per glass, base class) followed by the price per bottle
            get { return base.PriceDisplay + "    €" + PricePerBottle.ToString("##.00"); }
        }

        public override string Name
        {
            get { return Type.ToString() + " - " + base.Name; }
            set { base.Name = value; }
        }

        //abstract properties in base class -> MUST be overriden 
        public override string Sign => "W"; //automatically generated lambda expression
        //public override string Sign { get { return "W"; } } //alternative for lambda expression

        public override string Description
        {
            get
            {   //show country and grapes in the description
                string description = Country + ", grape: ";
                foreach (string grape in Grapes)
                    description += grape + ", ";
                return description;
            }
        }

        //virtual method in baseclass => CAN be overriden (in this case: replace all default behavior)
        public override void ShowServingInstructions()
        {
            Debug.WriteLine("This is how you serve {0}:", this.Name);
            Debug.WriteLine("* take a wine glass");
            Debug.WriteLine("* open the bottle of {0} in front of the client");
            Debug.WriteLine("* pour a sip of wine in the glass");
            Debug.WriteLine("* let the client taste");
            Debug.WriteLine("* serve every client at the table");
        }
    }
}
