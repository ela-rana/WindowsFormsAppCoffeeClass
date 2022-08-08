using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppCoffeeClass
{
    enum HeatCategory
    {
        Hot,
        Cold,
        Iced,
        FrozenBlended
    }

    enum Size
    {
        Medium, //Medium will be the default size when size is not selected
        Large,
        ExtraLarge,
        Small
    }
    enum CoffeeTypes
    {
        PlainLightRoasted,  //considered a low-price drink
        PlainDarkRoasted,   //considered a low-price  drink
        Decaf,   //considered a low-price  drink
        Milk,   //considered a low-price  drink
        Chocolate,   //considered a meduim-price drink
        Latte,   //considered a meduim-price drink
        Mocha,   //considered a meduim-price drink
        Cappuccino,   //considered a high-price drink
        Frappuccino,   //considered a high-price drink
        Espresso   //considered a high-price drink
    }

    enum Flavors
    {
        None,
        Hazelnut,
        Caramel,
        Chocolate,
        WhiteChocolate,
        Vanilla
    }

    internal class Beverage
    {
        public virtual string BevName { get; set; }    
        public string BrandName { get; set; }
        public virtual double BasePrice { get; set; }   //Base price of a Medium size beverage with no additions
        public Size BevSize { get; set; }
        public HeatCategory DrinkTemperature { get; set; }
        public virtual double TotalPrice
        {
            get
            {
                return this.TotalPrice;
            }
            set
            {
                double total = this.BasePrice;
                switch (this.BevSize.ToString())
                {
                    case "Small":
                        total = .75 * total;    //to make small drinks 25% cheaper than default medium drinks
                        break;
                    case "Medium":  //no change to medium since it is the default drink
                        break;
                    case "Large":
                        total = 1.25 * total;    //to make large drinks 25% more expensive than default medium drinks
                        break;
                    case "ExtraLarge":
                        total = 1.5 * total;    //to make extra large drinks 50% more expensive than default medium drinks
                        break;
                }
                this.TotalPrice = total;    //to set the price with size changes saved in total to the TotalPrice
            }
        }
        public Beverage()
        {
            this.BevSize = (Size)0; //to set default beverage size as medium if it is not entered
            this.BrandName = "None"; //to set default brandname as None in case the drink does not have a brand
            this.DrinkTemperature = (HeatCategory)2;    //to set temperature to iced as default
        }
    }
    internal class Coffee : Beverage
    {
        public int Pumps { get; set; }  //to save value of how many pumps of flavor additions the customer wants
        public bool WhippedCream { get; set; }  //boolean to save whether customer wants whipped cream on top or not
        public CoffeeTypes CoffeeType { get; set; }
        public Flavors[] PumpFlavor { get; set; }
        public override string BevName
        {
            get
            {
                return this.BevName;
            }
            set
            {
                this.BevName = "Coffee";
            }
        }
        public override double BasePrice 
        { 
            get 
            { 
                return this.BasePrice; 
            }
            set
            {
                if (CoffeeType <= (CoffeeTypes)3)
                {
                    this.BasePrice = 1.25;  //to set baseprice of low-price drinks- PlainLightRoasted, PlainDarkRoasted, Decaf, and Milk to $1.25
                }
                else if(CoffeeType <= (CoffeeTypes)6)
                {
                    this.BasePrice = 2; //to set baseprice of medium-priced drinks- Chocolate, Latte, and Mocha to $2.00
                }
                else
                {
                    this.BasePrice = 3.25;  //to set baseprice of high-priced drinks- Cappuccino, Frappuccino, and Espresso to $3.25
                }    
            }
        }
        public override double TotalPrice
        {
            get
            {
                return this.TotalPrice;
            }
            set
            {
                double total = this.BasePrice;
                switch (this.BevSize.ToString())    //to add price changes to base price for different drink sizes (same functionality as base property)
                {
                    case "Small":
                        total = .75 * total;
                        break;
                    case "Medium":
                        break;
                    case "Large":
                        total = 1.25 * total;
                        break;
                    case "ExtraLarge":
                        total = 1.5 * total;
                        break;
                }
                foreach (Flavors f in PumpFlavor)   //to add 75 cents extra for each additional flavor pump requested by customer
                {
                    if (PumpFlavor.ToString() != "None")
                    {
                        total = total + .75;    //For each additional pump of flavor added, and additional 75 cents is charged
                    }
                }
                this.TotalPrice = total;    //the updated total is saved to TotalPrice
            }
        }
    }
}
