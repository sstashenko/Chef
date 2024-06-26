using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef
{
    // Інтерфейс для підрахунку загальної вартості (не бібліотечний)
    public interface ICostCalculable
    {
        double CalculateTotalCost();
    }

}
