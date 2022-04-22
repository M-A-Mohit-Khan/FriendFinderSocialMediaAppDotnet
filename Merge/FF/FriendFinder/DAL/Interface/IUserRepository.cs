using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IUserRepository<T1>
    {
        bool Register(T1 e);
        bool Login(T1 e);
    }
}
