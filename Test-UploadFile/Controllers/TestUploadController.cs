using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Test_UploadFile.Interface;
using Test_UploadFile.Models;

namespace Test_UploadFile.Controllers
{
    public class TestUploadController : Controller
    {
        private readonly IWebHostEnvironment _enviroment;
        public IFileUpload _iEmplois;

        public TestUploadController(IWebHostEnvironment enviroment, IFileUpload iEmplois)
        {
            _enviroment = enviroment;
            _iEmplois = iEmplois;
        }
        

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(IFormFile file_input)
        {
            //
            var filePath = Path.Combine(_enviroment.ContentRootPath, "UploadFile_csv", file_input.FileName);
            
            List<Emploes_input> ListEmp = _iEmplois.GetEmploes_from_file_csv(filePath.ToString());

            var resultEmploes = _iEmplois.Find_Pair_OldEmploes(ListEmp);
            
            return View(resultEmploes);
        }
    }
}
