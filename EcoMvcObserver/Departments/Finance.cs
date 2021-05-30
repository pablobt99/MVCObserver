using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoMvcObserver.Departments
{


    public interface IFinance
    {
    void CalculateSalary();
    }

    public class Finance : IFinance
    {
        public void CalculateSalary()
        {
            //calcularte salry
        }
    }
}
