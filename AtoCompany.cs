using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AvtoCompany : Company
{
    /// <summary>
    /// Количество автомобилей
    /// </summary>
    int count;
    /// <summary>
    /// Объём грузоперевозок
    /// </summary>
    int haul;
    //-------описание методов-------
    /// <summary>
    /// Определение среднего объёма грузоперевозок
    /// </summary>
    /// <returns></returns>
    public int averageAvto()
    {
        return haul / count;
    }
}
