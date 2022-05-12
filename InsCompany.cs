using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InsCompany	
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
    //-------описание методов-------
    /// <summary>
    /// Вычисление среднего размера сраховых взносов
    /// </summary>
    /// <returns></returns>
    public int averageInsSumma()
    {
        return summaplus / counts;
    }

}
