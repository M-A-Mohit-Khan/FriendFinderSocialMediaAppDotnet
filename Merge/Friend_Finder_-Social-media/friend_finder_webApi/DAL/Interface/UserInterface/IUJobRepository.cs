using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.UserInterface
{
    public interface IUJobRepository<T,ID>
    {
        List<T> Get();
        T Get(ID id);
    }
}
