using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVPROG_DEMO_04.Model
{
    //this is no drink, but it IS collectable
    public class ComicBook : ICollectable
    {
        //IMPLEMENTING the ICollectable interface
        public int YearOfOrigin { get; set; }

        //extra properties
        public string Title { get; set; }
        public string Summary { get; set; }

    }
}
