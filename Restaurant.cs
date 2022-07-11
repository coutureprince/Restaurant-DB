using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyrshovayaa
{
    public class Restaurant
    {
        private string Name; //название ресторана

        private List<Menu> Dishes = new List<Menu>();
        public Restaurant(string Name) => this.Name = Name; // конструктор
        public void Addbludo(Menu bludo) => Dishes.Add(bludo); // добавить в список
        public void Removebludo(Menu bludo) => Dishes.Remove(bludo); // убрать из списка
        public List<Menu> CheckList() => Dishes; // вернуть список
      
 
    }
}
