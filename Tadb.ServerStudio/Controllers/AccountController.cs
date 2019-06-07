using RestSharp;
using System.Net;
using System.Web.Mvc;
using System.Web.Security;
using Tadb.ServerStudio.Models;

namespace Tadb.ServerStudio.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        public AccountController()
        {
            this.Client = new RestClient("http://localhost:64449");
        }

        public RestClient Client { get; set; }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel loginModel, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(loginModel);
            }

            var request = new RestRequest("api/LoginModels", Method.POST);
            request.AddJsonBody(loginModel);

            var response = Client.Post(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                FormsAuthentication.SetAuthCookie(loginModel.Username, createPersistentCookie: true);
                return Redirect(string.IsNullOrWhiteSpace(returnUrl) ? "~" : returnUrl);
            }

            ModelState.AddModelError("", "Неверный логин или пароль");
            return View(loginModel);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}