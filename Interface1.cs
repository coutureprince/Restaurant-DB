using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyrshovayaa
{
    public interface Interface1
    { 
        const int maxtables = 100;// константа // макс количество столиков
        static int mintable = 1;    // статическая переменная
        void Clean();   // очистка
        string Name { get; set; }  // название
        delegate void MoveHandler(string message); // определение делегата для события
        event MoveHandler MoveEvent;    // событие движения
      // static int Maxtables
      // {
       //     get => maxtables;
        //set
         //   {
          //      if (maxtables > 100) maxtables = false;
          //  }
       // }
    }
}
