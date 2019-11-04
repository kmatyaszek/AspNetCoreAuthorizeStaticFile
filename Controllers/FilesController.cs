using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreAuthorizeStaticFile.Controllers
{
    public class FilesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult GetSecretDocument()
        {
            var file = Path.Combine(Directory.GetCurrentDirectory(),
                "SecureFiles", "secret.pdf");

            return PhysicalFile(file, "application/pdf");
        }
    }
}