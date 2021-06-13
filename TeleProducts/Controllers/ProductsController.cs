using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeleProducts.Models;

namespace TeleProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class ProductsController : ControllerBase
    {
        ApplicationDbContext db;
        public ProductsController(ApplicationDbContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public IActionResult GetAll() 
        {
            List<Products> products = db.Products.ToList();
            return Ok(products);
        }
        [HttpPost]
        public IActionResult Add([FromBody]Products pr) 
        {
            if (pr == null)
            {
               
                 return BadRequest();
                //Console.WriteLine("no data ");
            }
            else
            {
                db.Products.Add(pr);
                db.SaveChanges();
                List<Products> products = db.Products.ToList();
                return Ok(products);
            }
        }
        [HttpPut]
        public IActionResult Edit(int id, Products pr) 
        {
            Products prr = db.Products.Where(n => n.ID == id).FirstOrDefault();
            prr.Name = pr.Name;
            prr.Status = pr.Status;
            prr.Desc = pr.Desc;
            prr.imageURl = pr.imageURl;
            db.SaveChanges();
            List<Products> products = db.Products.ToList();
            return Ok(products);
        }
        [HttpDelete]
        public IActionResult Delete(int id) 
        {
            Products pr = db.Products.Where(n => n.ID == id).FirstOrDefault();
            db.Products.Remove(pr);
            db.SaveChanges();
            List<Products> products = db.Products.ToList();
            return Ok(products);
        }
    }
}
