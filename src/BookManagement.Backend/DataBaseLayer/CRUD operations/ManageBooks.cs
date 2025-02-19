using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLayer.ApplicationFolder;
using BusinessLayer;

namespace DataBaseLayer.CRUD_operations
{
    public class ManageBooks
    {
        private readonly ApplicationDBContext dBContext;
        public ManageBooks(ApplicationDBContext Context)
        {
            dBContext = Context;
        }

        public void addBook(BookModel Model)
        {
            Book Add = new Book()
            {
                Title = Model.Title,
                PublishedDay = Model.PublishedDay,
                AuthorName = Model.AuthorName,
                Views = Model.Views
            };

            dBContext.Books.Add(Add);
            dBContext.SaveChanges();
        }
    }
}
