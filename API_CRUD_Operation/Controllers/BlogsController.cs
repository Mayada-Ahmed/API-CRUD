using API_CRUD_Operation.DTO;
using API_CRUD_Operation.Models;
using API_CRUD_Operation.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API_CRUD_Operation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IBlogService blogService;

        #region Injection
        public BlogsController(IBlogService blogService)
        {
            this.blogService = blogService;
        }
        #endregion

        #region Get all Blogs
        [HttpGet]
        public IActionResult GetBlogs()
        {
            var product = blogService.GetAll();
            return Ok(product);
        }
        #endregion


        #region Get Blog
        [HttpGet("{id}")]
        public IActionResult GetBlog(int id)
        {
            var product = blogService.GetById(id);

            if (product == null)
                return NotFound();
            return Ok(product);
        }
        #endregion


        #region Add Blog
        [HttpPost]
        public IActionResult PostBlog(Blog blog)
        {
            if (ModelState.IsValid)
            {
                blogService.Insert(blog);
                return Ok(blog);
            }
            else
            {
                return BadRequest(blog);
            }
        }
        #endregion

        #region Edit Blog

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody]BlogDTO BlogDto)
        {
            var blog = blogService.GetById(id);
            if (blog == null)
            {
                return NotFound();
            }
            else
            {
                blog.Title = BlogDto.Title;
                blog.Body = BlogDto.Body;
                blogService.Update(blog);
                return Ok(blog);
            }
      
        }
        #endregion

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var blog = blogService.GetById(id);
            if(blog == null)
            {
                return NotFound();
            }
            else
            {
                blogService.Delete(id);
                return Ok();
            }
        }
    }
}
