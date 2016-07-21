using System.Web.Mvc;
using DapperORM.Core.Entities;
using DapperORM.Core.Services;

namespace DapperORM.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _iUserService;
        public HomeController(IUserService iUserService)
        {
            _iUserService = iUserService;
        }

        public ActionResult Index()
        {
            var insert1 = _iUserService.InsertOrUpdateWithoutIdentity(new User{UserId = 1, UserName = "Admin1"});
            var insert2 = _iUserService.InsertOrUpdateWithoutIdentity(new User { UserId = 2, UserName = "Admin2" });
            var insert3 = _iUserService.InsertOrUpdateWithoutIdentity(new User { UserId = 3, UserName = "Admin3" });
            var insert4 = _iUserService.InsertOrUpdateWithoutIdentity(new User { UserId = 3, UserName = "Admin4",Password = "1234",ConfirmPassword = "1234"});

            var get = _iUserService.Get(new User {UserId = 2});

            var getAll = _iUserService.GetAll();

            var delete = _iUserService.Delete(new User { UserId = 3 });

            var data = _iUserService.GetAll();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}