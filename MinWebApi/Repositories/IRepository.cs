using System.Collections.Generic;

namespace MinWebApi.Repositories
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(string id);
        T Create(T entity);
        void Delete(string id);
    }
}
