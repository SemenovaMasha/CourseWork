using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public abstract class Product
    {
       public abstract int getPrice();
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

        override public int getPrice()
        {
            int p = type == "Computer" ? 1000 : 500;
            DataTable dt = ConnectionClass.getResult(@"SELECT min(Price) FROM ProvidersList where Material='"+material+"';");
            p += Convert.ToInt32(backHeight) * Convert.ToInt32(dt.Rows[0][0].ToString())/10 ;

            return p;
        }
    }
    public class Cupboard: Product
    {
        public Cupboard(string type, string material, string height, string width, string doorMaterial, string shelfNum)
        {
            this.type = type;
            this.material = material;
            this.height = height;
            this.width = width;
            this.doorMaterial = doorMaterial;
            this.shelfNum = shelfNum;
        }
        public string type;
        public string material;
        public string height;
        public string width;
        public string doorMaterial;
        public string shelfNum;

        public override int getPrice()
        {
            int p = type == "Closet" ? 2000 : 1500;
            DataTable dt = ConnectionClass.getResult(@"SELECT min(Price) FROM ProvidersList where Material='" + material + "';");
            p += Convert.ToInt32(height) * Convert.ToInt32(width) * Convert.ToInt32(dt.Rows[0][0].ToString()) / 10;
            dt = ConnectionClass.getResult(@"SELECT min(Price) FROM ProvidersList where Material='" + doorMaterial + "';");
            p += Convert.ToInt32(height) * Convert.ToInt32(width) * Convert.ToInt32(dt.Rows[0][0].ToString()) / 100;

            p += Convert.ToInt32(shelfNum)* 1000;

            return p;
        }
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

        public override int getPrice()
        {
            int p = type == "Computer" ? 1000 : 500;
            DataTable dt = ConnectionClass.getResult(@"SELECT min(Price) FROM ProvidersList where Material='" + material + "';");
            p += Convert.ToInt32(height) * Convert.ToInt32(width) * Convert.ToInt32(dt.Rows[0][0].ToString()) / 10;
            p += Convert.ToInt32(legNumber) * 500;

            return p;
        }
    }
}
