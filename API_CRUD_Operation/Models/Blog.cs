using System;
using System.ComponentModel.DataAnnotations;

namespace API_CRUD_Operation.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
    }
}
