﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IApplicantRepository<T, ID>
    {
        bool Add(T e);
        bool delete(ID id);
        //List<T> Get(ID id);

    }
}
