using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoMvcObserver.Departments
{
    public interface IAsset
    {
        void AllocateAsset();
    }
    public class IT: IAsset
    {
        public void AllocateAsset()
        {

        }
    }
}
