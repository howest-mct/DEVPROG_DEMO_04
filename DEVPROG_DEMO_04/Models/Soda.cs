using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVPROG_DEMO_04.Models
{
    public class Soda : Drink   //automatically implement class using 'lightbulb' quick actions
    { 
        //extra properties
        public bool IsSugarFree { get; set; }

        //abstract properties in base class => MUST be overriden
        public override string Sign => "S"; //automatically generated lambda expression
        //public override string Sign { get { return "S"; } } //alternative for lambda expression

        public override string Description
        {
            get
            {   //only show a description if the soda is sugar free
                if (!IsSugarFree)
                    return string.Empty;
                return "sugar free";
            }
        }
    }
}
