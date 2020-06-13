using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    [Serializable]
    public class Item
    {
        public string Name;
        public enum TCategories {Bottle, High_Alcholol, Low_Alcholol, Medium_Alcholol, UserDrink };
        public double Price;
        public int Count;
        public string Country;

        public TCategories Category;

        public Item(string name, double price,int count, string country)
        {
            this.Name = name;
            this.Price = price;
            this.Count =count;
            this.Country = country;
      
        }

    }

    [Serializable]
    public class UserDrink:Item
    {
        
        public double Degree;
        public int Year;

        public UserDrink(double degree,int year ,string name, double price, int count, string country):base(name,price,count,country)
        {
            this.Degree = degree;
            this.Year = year;
            this.Category = TCategories.UserDrink;
           
        }
    }

    [Serializable]
    public class Bottle:Item
    {
        public double Volume;
        public enum TType
        {
            bottle,
            magnum,
            jeroboam,
            methuselah
        }
        public TType BType;
        public Bottle(double volume,TType btype,string name, double price, int count, string country /*Bottle bottle*/) : base(name, price, count, country/* bottle*/)
        {
            this.Volume = volume;
            this.BType = btype;
           // this.Bottle = bottle;
            this.Category = TCategories.Bottle;
        }
    }

    [Serializable]
    public class High_Alcholol:UserDrink
    {
        public Bottle Bottle;
        public enum TFlavorin_additives
        {

            spice,
            water,
            juice
        }
        public TFlavorin_additives Flavorin_additives;
        public enum TRaw_Materials
        {
            Alpha,
            Suite,
            Extra
        }
        public TRaw_Materials Raw_Materials;
        public enum TType
        {
            special,
            simple
        }
        public TType HAType;
        public High_Alcholol(Bottle bottle,TFlavorin_additives flavorin_additives, TRaw_Materials raw_materials, TType btype, double degree, int year, string name, double price, int count, string country) : base(degree,year,name, price, count, country)
        {
            this.Bottle = bottle;
            this.Flavorin_additives = flavorin_additives;
            this.Raw_Materials = raw_materials;
            this.HAType = btype;
            this.Category = TCategories.High_Alcholol;
        }
    }


    [Serializable]
    public class Low_Alcholol:UserDrink
    {
        public Bottle Bottle;
        public double Temperature;

        public enum TFlavorin_additives
        {

            spice,
            water,
            juice,
            alcholol
        }

        public TFlavorin_additives Flavorin_Additives;
        public enum TCooking_Method
        {
            distillation,
            tincture
        }

        public TCooking_Method Cooking_Method;
        public string Ingridients;
        public string Recipe;
        public bool Aroma;
        public bool Fruit;
        public Low_Alcholol(TFlavorin_additives flavorin_additives, TCooking_Method tcooking_method, string ingridients, string recipe, bool aroma, bool fruit, double degree, int year, string name, double price, int count, string country,Bottle bottle) : base(degree, year, name, price, count, country)
        {
            this.Flavorin_Additives = flavorin_additives;
            this.Cooking_Method = tcooking_method;
            this.Ingridients = ingridients;
            this.Recipe = recipe;
            this.Aroma = aroma;
            this.Fruit = fruit;
            this.Category = TCategories.Low_Alcholol;
            this.Bottle = bottle;
        }
    }

    [Serializable]
    public class Medium_Alcholol : UserDrink
    {
        public Bottle Bottle;
        public enum TType
        {
            punch,
            coctail,
            liquors,
            wine
        }
        public TType MType;
        public string Recipe;
        public enum TCooking_Method
        {
            distillation,
            tincture
        }
        public TCooking_Method Cooking_Method;
        public enum TColor
        {
            Red,
            White,
            Pink
        }
        public TColor Color;
        public enum TShugar
        {
            sweet,
            semisweet,
            dry,
            semidry
        }
        public TShugar Shugar;
        public Medium_Alcholol(Bottle bottle,TType mtype,string recipe, TCooking_Method cooking_method, TColor color, TShugar shugar, double degree, int year, string name, double price, int count, string country) : base(degree, year, name, price, count, country)
        {
            this.Bottle = bottle;
            this.Cooking_Method = cooking_method;
            this.Shugar = shugar;
            this.Recipe = recipe;
            this.MType = mtype;
            this.Color = color;
            this.Category = TCategories.Medium_Alcholol;
        }

    }

    
      

}
