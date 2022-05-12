using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    //Особенности конструкторов:
    //1. Конструкторы не наследуются
    //2. Конструктор производного класса:
    // вызывает конструктор базового класса, который создаёт часть объекта,
    //   соответствующую базовому классу
    // создаёт часть объекта, соотвутствующую проиводному классу
    //3. Если в базовом классе описан конструктор, то все классы, которые от него наследуют, также должны
    //содержать конструктор
    class Program
    {
        static void Main(string[] args)
        {
            int i, ///параметр цикла 
            min, ///наименьшая сума страхвых взносов
            temp, j; ///вспомогательные переменные
            min = 0;
            j = 0;
            //создание массива ссылок
            //на объекты класса InsCopmany
            InsCompany[] CityCompany = new InsCompany[4];
            //создание и инициализация объектов
            CityCompany[0] = new InsCompany("ABC", 100, 10000, 111, 111111, 1111);
            CityCompany[1] = new InsCompany("BCD", 200, 200000, 222, 222222, 2222);
            CityCompany[2] = new InsCompany("CDE", 300, 300000, 333, 333333, 3333);
            CityCompany[3] = new InsCompany("DEF", 400, 400000, 444, 444444, 4444);
            //печать информации о страховых компаниях
            for (i = 0; i < 4; i++)
            {
                temp = CityCompany[i].Summaplus;
                if (temp < min)
                {
                    min = temp;
                    j = i;
                }
                CityCompany[i].show();
            }
            Console.WriteLine($"\n наименьшая сумма взносов в компании {CityCompany[j].Name}");
        }
    }
}
