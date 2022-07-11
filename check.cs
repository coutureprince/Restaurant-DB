using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyrshovayaa
{
    public class Check
    {
        private Clientinformation client;
      
        private List<Menu> Dishes= new List<Menu>();
         
        public Check(Clientinformation client)
        {
            this.client = client;
        }

        public void Addbludo(Menu bludo) => Dishes.Add(bludo); // добавить в список
        public void Removebludo(Menu bludo) => Dishes.Remove(bludo); // убрать из списка
        public double GetPrice() => Math.Round(Dishes.Sum(b => b.Price), 2);// счет
      //  public DateTime GetTimeReturn() => TimeRent.AddHours(RentalPeriod); // получить время заказа
        public List<Menu> CheckList() => Dishes;

    }
}
