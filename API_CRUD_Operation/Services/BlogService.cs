using API_CRUD_Operation.Data;
using API_CRUD_Operation.DTO;
using API_CRUD_Operation.Models;
using System.Collections.Generic;
using System.Linq;

namespace API_CRUD_Operation.Services
{
    public class BlogService : IBlogService
    {

        private readonly Context context;

        public BlogService(Context context)
        {
            this.context = context;
        }

        public List<Blog> GetAll()
        {

            return context.Blogs.OrderBy(b=>b.Date).ToList();
        }

        public Blog GetById(int id)
        {
            return context.Blogs.FirstOrDefault(b => b.Id == id);
        }
        public void Insert(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var blog = context.Blogs.FirstOrDefault(b => b.Id == id);
            context.Blogs.Remove(blog);
            context.SaveChanges();
        }

        public void Update(Blog blog)
        {
            //var oldBlog = context.Blogs.FirstOrDefault(b => b.Id == id);
            //oldBlog.Title = blog.Title;
            //oldBlog.Body = blog.Body;
            context.Blogs.Update(blog);
            context.SaveChanges();
        }
    }
}
