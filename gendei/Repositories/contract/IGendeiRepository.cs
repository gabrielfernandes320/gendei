﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gendei.Repositories.contract
{
    public interface IGendeiRepository<T>
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> Get(int id);

        Task<T> Update(int id, object obj);

        bool Exists(int id);

        Task<T> Add(object obj);

        Task<T> Delete(object obj);
    }
}
