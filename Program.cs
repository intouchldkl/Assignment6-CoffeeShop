using System;

namespace Assignment6_CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Drink[] drinks = new Drink[10];

            drinks[0] = new Drink("coffee", 50);

            drinks[1] = new Drink("tea", 45);
            drinks[2] = new Drink("juice", 30);
            drinks[3] = new Drink("juice", 30);
            int countOfCoffee = 0;
            int countOfTea = 0;
            int countOfJuice = 0;
            int count = 0;
            int total = 0;
            for(int i = 0;i < drinks.Length; i++)
            {
                if(drinks[i] != null)
                {
                    Console.WriteLine(drinks[i].GetName());
                    count = count + 1;
                    total = total + drinks[i].GetPrice();

                    if (drinks[i].GetName() == "coffee")
                    {
                        countOfCoffee++;

                    }
                    else if (drinks[i].GetName() == "tea")
                    {
                        countOfTea++;

                    }
                    else if (drinks[i].GetName() == "juice")
                    {
                        countOfJuice++;

                    }
                }

                
            }
            Console.WriteLine(countOfCoffee);
            Console.WriteLine(countOfTea);
            Console.WriteLine(countOfJuice);

        }
    }
}
