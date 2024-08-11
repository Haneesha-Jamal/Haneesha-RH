using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MvcCrud.Dto;
using MvcCrud.Interface;
using MvcCrud.Models;

namespace MvcCrud.Controllers
{
    public class ProductController : Controller
    {
        IMapper _mapper;
        IProduct _product;
        public ProductController(IMapper mapper, IProduct product)
        {
            _product = product;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult Add(ProDto prdto)
        {
            var prod = _mapper.Map<Products>(prdto);
            _product.AddProduct(prod);
            return RedirectToAction("ViewProduct");
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var pro = _product.GetProductById(id);
            if(pro == null)
            {
                return  NotFound();
            }

            var prductDto = _mapper.Map<ProDto>(pro);
            return View(prductDto);
        }

        [HttpPost]
        public IActionResult Edit(int id,ProDto pro)
        {
            if(id != pro.Id)
            {
                return NotFound();
            }

            if(ModelState.IsValid)
            {
                var producttt = _mapper.Map<Products>(pro);
                _product.UpdateProduct(producttt);
                return RedirectToAction("ViewProduct");
            }
            return View(pro);
        }   
    }
}
