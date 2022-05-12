using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    public class InsCompany : Company
    {
        /// <summary>
        /// Количество застрахованных лиц
        /// </summary>
        int counts;
        /// <summary>
        /// Сумма страховых взносов
        /// </summary>
        int summaplus;
        /// <summary>
        /// Сумма страховых выплат
        /// </summary>
        int summaminus;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="persons">Количесто сотрудников</param>
        /// <param name="money">Месячный фонд</param>
        /// <param name="counts">Количество застрахованных лиц</param>
        /// <param name="summaplus">Сумма стразовых взносов</param>
        /// <param name="summaminus">Сумма страховых выплат</param>
        public InsCompany (string name, int persons, int money, int counts, int summaplus, int summaminus) : base (name, persons, money)
        {
            this.counts = counts;
            this.summaplus = summaplus;
            this.summaminus = summaminus;
        }
        /// <summary>
        /// свойство
        /// </summary>
        public int Summaplus
        {
            get { return summaplus; }
        }
        //-------описание методов-------
        new public void show()
        {
            base.show();
            Console.WriteLine($"Застрахованных лиц {counts} взносы {summaplus} выплаты {summaminus}");
        }
        /// <summary>
        /// Вычисление среднего размера сраховых взносов
        /// </summary>
        /// <returns></returns>
        public int averageInsSumma()
        {
            return summaplus / counts;
        }

    }
}
