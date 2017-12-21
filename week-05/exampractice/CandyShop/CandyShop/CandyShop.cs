using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperCandyShop
{
    public class CandyShop
    {
        Sweets SweetySweety;
        public double Income { get; set; } = 0;
        public double SugarInStock { get; set; }
        private int lollipopsInStock = 0;
        private int CandysInStock = 0;
        public List<Sweets> CandyStorage = new List<Sweets>();

        public CandyShop(int sugarGramm)
        {
            SugarInStock = sugarGramm;
        }

        public void CreateSweets(string typeOfTheSweet)
        {
            if (typeOfTheSweet == "lollipop")
            {
                if (SugarInStock < 5)
                {
                    Console.WriteLine("Dont have enough sugar in stock");
                }
                else
                {
                    CandyStorage.Add(new Lollipop());
                    SugarInStock -= 5;
                    lollipopsInStock++;
                }
            }
            if (typeOfTheSweet == "candy")
            {
                if (SugarInStock < 10)
                {
                    Console.WriteLine("Dont have enough sugar in stock");
                }
                else
                {
                    CandyStorage.Add(new Candy());
                    SugarInStock -= 10;
                    CandysInStock++;
                }
            }
        }

        public void Sell(string type, int numberOfSell)
        {
            if (numberOfSell > CandysInStock && type == "candy" || numberOfSell > lollipopsInStock && type == "lollipop")
            {
                Console.WriteLine("We dont have that much " + type + " you fatass idiot");
            }
            else
            {
                for (int i = 0; i < CandyStorage.Count; i++)
                {
                    if (CandyStorage[i].Type == type)
                    {
                        Income += CandyStorage[i].Price;
                        CandyStorage.Remove(CandyStorage[i]);
                    }
                }
                if (type == "lollipop")
                {
                    lollipopsInStock = lollipopsInStock - numberOfSell;
                }
                if (type == "candy")
                {
                    CandysInStock = CandysInStock - numberOfSell;
                }
            }
        }

        public void BuySugar(int sugarAmount)
        {
            int sugarPrice = sugarAmount / 10;

            if (Income < sugarPrice)
            {
                Console.WriteLine("Don't have enough money!");
            }
            else
            {
                SugarInStock += sugarAmount;
                Income -= sugarPrice;
            }
        }

        public void Raise(int percentage)
        {
            foreach (Sweets sweet in CandyStorage)
            {
                sweet.Price = sweet.Price * ( Convert.ToDouble(percentage) / 100.0);
                //SweetySweety.Price = SweetySweety.Price * (Convert.ToDouble(percentage) / 100.0);

            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Inventory: {0} candies, {1} lollipops, Income: {2} $, Sugar: {3}gr  \n", CandysInStock, lollipopsInStock, Income, SugarInStock);
        }
    }
}