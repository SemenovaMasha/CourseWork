using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class Product
    {

    }
    public class Chair: Product
    {
        public Chair(string type, string material,string backForm,string backHeight)
        {
            this.type = type;
            this.material = material;
            this.backForm = backForm;
            this.backHeight = backHeight;
        }
        public string type;
        public string material;
        public string backForm;
        public string backHeight;
    }
    public class Cupboard: Product
    {
        public Cupboard(string type, string material, string height, string width, string doorMaterial, string shelf1, string shelf2)
        {
            this.type = type;
            this.material = material;
            this.height = height;
            this.width = width;
            this.doorMaterial = doorMaterial;
            this.shelf1 = shelf1;
            this.shelf2 = shelf2;
        }
        public string type;
        public string material;
        public string height;
        public string width;
        public string doorMaterial;
        public string shelf1;
        public string shelf2;
    }
    public class Table: Product
    {
        public Table(string type, string material, string legNumber, string form, string height, string width)
        {
            this.type = type;
            this.material = material;
            this.legNumber = legNumber;
            this.form = form;
            this.height = height;
            this.width = width;
        }
        public string type;
        public string material;
        public string legNumber;
        public string form;
        public string height;
        public string width;
    }
}
