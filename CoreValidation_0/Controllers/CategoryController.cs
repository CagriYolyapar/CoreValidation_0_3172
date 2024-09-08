using CoreValidation_0.Models.Categories.PureVMs.RequestModels;
using CoreValidation_0.Models.ContextClasses;
using CoreValidation_0.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreValidation_0.Controllers
{
    public class CategoryController : Controller
    {
        MyContext _db;

        public CategoryController(MyContext db)
        {
            _db = db;
        }

        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryRequestModel model)
        {
            //Server Side Validation'da bilgiler back end'e gönderilir ve kontrol öyle saglanır...

            //Client Side Validation'da bilgiler istemciden ayrılamaz Validation Front End'de kontrol edilir...Bunun icin tek yapmanız gereken şey .Net Core MVC'deki kütüphaneyi kullanmaktır...

            if (ModelState.IsValid) //Model Durumu Validation'dan gecmişsse
            {
                Category c = new()
                {
                    CategoryName = model.CategoryName,
                    Description = model.Description
                };
                _db.Categories.Add(c);
                _db.SaveChanges();
                return RedirectToAction("GetCategories");
            }

            return View(model); //Eger Validation'da takılmıssak dikkat ederseniz tekrar aynı View'i döndürüyoruz...Döndürürken de View'a model yolluyoruz(Validation'da takıldıgımız modeli yolluyoruz ki kullanıcı hatalarını gözlemleyebilelim)
        }
    }
}
