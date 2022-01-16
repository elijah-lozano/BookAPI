using System;
namespace BookAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

        public Book(int Id, string title, string author, string description)
        {
            this.Id = Id;
            this.Title = title;
            this.Author = author;
            this.Description = description;
        }
    }
}