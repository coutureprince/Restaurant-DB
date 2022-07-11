using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kyrshovayaa
{
    public class delivery
    {

    }
        public class Food
        {
            public string nameofbludo; // имя блюда
            public double cena; // цена 
            public double ves; // вес
            public bool CheckRent; // false - недоступно для доставки, true - доступно
            public Food(string nameofbludo, double cena, double ves, bool CheckRent)
            {
                this.nameofbludo = nameofbludo;
                this.cena =cena;
                this.ves = ves;
                this.CheckRent = CheckRent;
            }
        }
        public class Rent
        {
            
            private string TimeRent;
            private double RentalPeriod;
            private List<Food> Delishes;
            public Rent(string DataReg, string TimeRent, double RentalPeriod)
            {
                this.TimeRent = TimeRent;
                this.RentalPeriod = RentalPeriod;
                Delishes = new List<Food>();
            }
            public void Adddeli(Food delish) => Delishes.Add(delish); // добавить в список
            public void Removedeli(Food delish) => Delishes.Remove(delish); // убрать из списка
            public double GetPrice() => Math.Round(Delishes.Sum(b => b.cena) , 2);// Цена аренды
          
            public List<Food> CheckList() => Delishes;
        }
        public class Restaurantdeliv
        {
            private string Name; // Название 

            private List<Food> Delishes = new List<Food>();
            public Restaurantdeliv(string Name) => this.Name = Name; // конструктор

            public void Adddeli(Food delish) => Delishes.Add(delish); // добавить в список
            public void Removedeli(Food delish) => Delishes.Remove(delish); // убрать из списка
            public List<Food> CheckList() => Delishes; // вернуть список
            public void RefreshStatus(Food delish) => delish.CheckRent = delish.CheckRent == true ? false : true;

        }
        public class Clientinf
        {
        public void SaveCheckClient2(List<Food> delish)
        {
            using (StreamWriter a = new StreamWriter(@"BD.txt", true))
            {
                foreach (var item in delish)
                {
                    a.WriteLine($"{item.nameofbludo}");
                }
            }
        }
        public string addres;
            public string LastName;
            public string Phone;
            public string typeofpay;
            public Clientinf(string addres, string LastName, string Phone,string typeofpay)
            {
                this.addres = addres;
                this.LastName = LastName;
                this.Phone = Phone;
                this .typeofpay = typeofpay;
            }
        public void zapis2(List<Food> Delishes, double price, employee employee)
        {
            using (StreamWriter a = new StreamWriter(@"BD.txt", true))
            {
                a.WriteLine($"ЗАКАЗ НА ДОМ: ФИО: {LastName}, Адрес: {addres} , Телефон:{Phone}");
                a.WriteLine("Заказ: ");
                foreach (var item in Delishes) a.WriteLine($"{item.nameofbludo}");
                a.WriteLine($"Цена: {price} + 15р");
                //a.WriteLine($"Фамилия: {employee.LastName}, {employee.post}, {employee.passport}");
                a.WriteLine("================================");
                a.WriteLine("");
            }
        }
    }


    
}
