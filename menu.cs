using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kyrshovayaa
{
    public class Menu
    {

        public string namebluda;  //имя блюда
        public double Price;      //цена 
        public double gramm;      //граммовка
        public Menu()
        {

        }

        public Menu(string namebluda, double Price, double gramm)
        {
            this.namebluda = namebluda;
            this.Price = Price;
            this.gramm = gramm;

        }
      
    }

}

