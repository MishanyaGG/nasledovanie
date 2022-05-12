using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    /// <summary>
    /// Поля и методы, общие для всех классов иерархии, описываются, как правило, в базовом классе.
    /// В некоторых случаях нет смысла создавать объект базового класса.
    /// Например, базовый класс "Компания" в иерархии "Компании города" не может быть
    /// использован для создания объекта, так как "просто компаний" не существует;
    /// все компании являются специализированными. Поэтому следует запретить создание объектов класса
    /// "Компания". Для этого в C# нужно объявить класс абстрактным.
    /// </summary>
    public class Company
    {   ///Если элементы базового класса объявлены с атрибутом private, то в
        ///производных классах они недоступны. Для того чтобы производный класс имел доступ
        ///к элементам базового класса, необязательно объявлять их с атрибутом public
        ///C# позволяет создавать защищенные элементы, которые доступны для своей иерархии, но
        ///закрыты вне этой иерархии. Защищённе элементы описыватся с помощью спецификатора доступа protected
        ///Таким образом, наследование обеспечивает ограничение доступа к элементам класса
        /// <summary>
        /// Название
        /// </summary>
        protected string name;
        /// <summary>
        /// Количество сотрудников
        /// </summary>
        protected int persons;
        /// <summary>
        /// Месячный фонд
        /// </summary>
        protected int money;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="persons">Количество сотрудников</param>
        /// <param name="money">Меячный фонд</param>
        public Company (string name, int persons, int money)
        {
            this.name = name;
            this.persons = persons;
            this.money = money;
        }
        /// <summary>
        /// Свойство
        /// </summary>
        public string Name
        {
            get { return name; }
        }
        //-------описание методов-------
        /// <summary>
        /// Печать информации о компании
        /// </summary>
        public void show()
        {
            Console.WriteLine($"В компании {name} трудятся {persons} сотрудников фонд заработной платы {money}");
        }
        /// <summary>
        /// Вычисление средней зарплат сотрудников
        /// </summary>
        /// <returns></returns>
        public int averageSalary()
        {
            return money / persons;
        }
        /// <summary>
        /// Определние наибольшего количества сотрудников при заданной средней зарплате
        /// </summary>
        /// <param name="salary">Средняя зарплата</param>
        /// <returns></returns>
        public int maxPersons(int salary)
        {
            return money / persons;
        }
        /// <summary>
        /// Определение суммы налога и отчислении в ПФ
        /// </summary>
        /// <param name="minus1">налог в %</param>
        /// <param name="minus2">отчисление в ПФ в %</param>
        /// <returns></returns>
        public int minus(int minus1, int minus2)
        {
            return money * (minus1 + minus2) / 100;
        }
    }
}
