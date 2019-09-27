using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCA
{
    public class pizza
    {
        public pizza()
        {
            this.Queso = new Queso();
        }
        //intancia d la clase queso
        //miobjetopizza.cocacola
        public Queso Queso { get; set; }
        public refresco refresco { get; set; }

    }
    public class Queso
    {

    }
    
}
