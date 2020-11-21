using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebDAO.Interfaces
{
    public interface IDAO<T> : IDisposable where T : class, new()
    {
        // CRUD
        // CREATE
        T Create(T model);

        // Find one by ID
        T FindByID(params Object[] keys);

        // Get all
        Collection<T> GetAll();

        // Update 
        void Update(T model);

        // Delete
        bool Delete(T model);

    }
}
