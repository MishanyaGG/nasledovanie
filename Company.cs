using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Company
{
    /// <summary>
    /// Название
    /// </summary>
    public string name;
    /// <summary>
    /// Количество сотрудников
    /// </summary>
    public int persons;
    /// <summary>
    /// Месячный фонд
    /// </summary>
    public int money;
    //-------описание методов-------
    /// <summary>
    /// Печать информации о компании
    /// </summary>
    public void show()
    {
        Console.WriteLine($"В компании {name} трудятся {persons} сотрудников");
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
    public int maxPersons (int salary)
    {
        return money / persons;
    }
    /// <summary>
    /// Определение суммы налога и отчислении в ПФ
    /// </summary>
    /// <param name="minus1">налог в %</param>
    /// <param name="minus2">отчисление в ПФ в %</param>
    /// <returns></returns>
    public int minus (int minus1, int minus2)
    {
        return money * (minus1 + minus2) / 100;
    }
}
