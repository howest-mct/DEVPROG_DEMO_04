using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVPROG_DEMO_04.Models
{
    public abstract class Drink 
    {
        //common variables - automatically inherited by subclasses:
        public double Price { get; set; }

        //virtual variables: automatically inherited but CAN be easily overriden
        public virtual string Name { get; set; }
        public virtual string PriceDisplay { get { return "€" + Price.ToString("##.00"); } }

        //abstract variables: MUST be overriden by subclasses
        public abstract string Sign { get;  }
        public abstract string Description { get; }


        //virtual method CAN be overriden by subclasses, but we give it a base implementation
        public virtual void ShowServingInstructions()
        {
            Debug.WriteLine("This is how you serve {0}:", this.Name);
            Debug.WriteLine("* take a glass");
            Debug.WriteLine("* open the bottle of " + this.Name);
            Debug.WriteLine("* pour the content of the bottle in the glass");
        }


        public override string ToString()
        {
            return this.Name;
        }
    }
}


