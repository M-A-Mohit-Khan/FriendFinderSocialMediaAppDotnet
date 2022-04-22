using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IMessageRepository<T, ID1, ID2>
    {
        bool Add(T e);
        List<T> Get(ID1 id1, ID2 id2);
    }
}
