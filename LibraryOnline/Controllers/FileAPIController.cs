using LibraryOnline.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace LibraryOnline.Controllers
{
    public class LoginInfo
    {



        public string User { get; set; }
        public string Pass { get; set; }
    }

    public class FileAPIController : ApiController
    {
        //LIBRARYEntities1 db = new LIBRARYEntities1();

        [Route("api/FileAPI/Login")]
        [HttpPost]
        public string Login(LoginInfo loginInfo)
        {
            using (LIBRARYEntities1 db = new LIBRARYEntities1())
            {
                var role = db.Users.Where(x => x.username == loginInfo.User && x.password == loginInfo.Pass)
                          .Select(x => x.role_id).FirstOrDefault();
                var user_id = db.Users.Where(x => x.username == loginInfo.User && x.password == loginInfo.Pass)
                    .Select(x => x.id).FirstOrDefault();
                HttpContext.Current.Session["username"] = loginInfo.User;
                HttpContext.Current.Session["user_id"] = user_id;
                if (role == 1)
                    return "/Admin/Index";

            }

            return "";
        }


        [Route("api/FileAPI/UploadEbook")]
        [HttpPost]
        public string UploadEbook(Ebook ebook)
        {
            //var fileName = Path.GetFileName(ebook.filename);
            //var path = Path.Combine(Server.MapPath("~/Assets/fileupload/user"),fileName);
            //eSaveAs(path);
            //ebook.filename = fileName;
            using (LIBRARYEntities1 db = new LIBRARYEntities1())
            {
                db.Ebooks.Add(ebook);
                db.SaveChanges();
            }
           
            return "aaaaaa";
        }
    }
}
