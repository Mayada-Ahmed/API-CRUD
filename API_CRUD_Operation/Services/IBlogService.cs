using API_CRUD_Operation.Models;
using System.Collections.Generic;

namespace API_CRUD_Operation.Services
{
    public interface IBlogService
    {
        void Delete(int id);
        List<Blog> GetAll();
        Blog GetById(int id);
        void Insert(Blog blog);
        void Update(Blog blog);
    }
}