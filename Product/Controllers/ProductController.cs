using Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Product.Controllers
{
    public class ProductController : Controller
    {
        private ProductContext data = new ProductContext();

        // GET: Product
        public ActionResult Index()
        {
            var thongtin = data.Sanpham.ToList();
            return View(thongtin);
        }
        public ActionResult Viewcreate() 
        {
            return View();
        }
        public ActionResult Create(int getid,string Name, string getgia,HttpPostedFileBase getanh,string getchitiet)
        {
            if (ModelState.IsValid) 
            {
                Sanpham item = new Sanpham();
                item.Id = getid;
                item.Name = Name;
                item.Price = float.Parse(getgia);
                if
                (getimgsp(getanh) == null)
                {
                    item.Image = null;
                }
                else
                {
                    item.Image = getimgsp(getanh);
                }
                item.Detail = getchitiet;
                data.Sanpham.Add(item);
                data.SaveChanges();
            }
           
            return RedirectToAction("Index");
        }
        public string getimgsp(HttpPostedFileBase file) 
        {
            if(file == null) 
            {
                return null;
            }
            else 
            {
                var filename = file.FileName;
                var getfile = "../imgsp/" + filename;
                file.SaveAs(Server.MapPath(getfile));
                return getfile;
            }
        }
    }
}