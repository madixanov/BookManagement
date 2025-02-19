using System.Reflection;
using BusinessLayer;
using DataBaseLayer.ApplicationFolder;
using DataBaseLayer.CRUD_operations;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class AddingController : Controller
    {

        private readonly ApplicationDBContext context;
        ManageBooks manageBooks;

        public AddingController(ApplicationDBContext _context)
        {
            context = _context;
            manageBooks = new ManageBooks(context);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult addBook(IFormCollection Form)
        {

            BookModel Model = new BookModel()
            {
                Title = Form["txtTitle"],
                AuthorName = Form["txtAuthorName"],
                
            };
            manageBooks.addBook(Model);
            return Ok("Successfully saved");

        }
    }
}
