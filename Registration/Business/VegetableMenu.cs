using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using privateconsloe.Repository;
using privateconsloe.Models;

namespace privateconsloe.Business
{
    public class VegetableMenu
    {
        public void Menu()
        {
            VegetableRepository obj = new VegetableRepository();
            Vegetableinfo obj1 = new Vegetableinfo();
            int a;

            do
            {
                Console.WriteLine("choose the option");
                Console.WriteLine("0.Exist");  
                Console.WriteLine("1.insert");
                Console.WriteLine("2.select");

                a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 0:
                        Console.WriteLine("Thank u");

                        break;

                    case 1:
                        var mini = obj.Models();
                        obj.insert(mini);
                        break;

                    case 2:
                        obj.select();
                        break;
                }
            } while (a != 0);
        }
    }
}
