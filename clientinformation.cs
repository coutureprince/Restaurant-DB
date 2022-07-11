using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kyrshovayaa
{
    public class Clientinformation : @abstract
    {
        public void SaveCheckClient(List<Menu> menu)
        {
                using (StreamWriter a = new StreamWriter(@"BD.txt", true))
            {
                foreach (var item in menu)
                {
                    a.WriteLine($"{item.namebluda}");
                }
            }
        }
            Menu edaa = new Menu();
        public int tablenumb;       //номер столика
        public string allergy;          //аллергии

        public Clientinformation(string LastName, int tablenumb,string allergy):base(LastName)
        {

            this.tablenumb = tablenumb;
            this.allergy = allergy; 
            //this.TimeRent = TimeRent;
        }
        public void zapis(List<Menu> dishes, double price, employee employee)
        {
            using (StreamWriter a = new StreamWriter(@"BD.txt", true))
            {
                a.WriteLine($"Номер столика: {tablenumb}, Фамилия: {LastName}, Аллергии: {allergy}");
                a.WriteLine("Заказ: ");
                foreach (var item in dishes) a.WriteLine($"{item.namebluda}");
                a.WriteLine($"Цена: {price}");
                //a.WriteLine($"Фамилия: {employee.LastName}, {employee.post}, {employee.passport}");
                a.WriteLine("================================");
                a.WriteLine("");
            }
        }
    
    }

}
