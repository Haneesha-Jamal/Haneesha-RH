using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MVCcrud1.Dal;
using MVCcrud1.Dto;
using MVCcrud1.Interface;
using MVCcrud1.Models;
using MVCcrud1.Service;

namespace MVCcrud1.Controllers
{
    public class StoreController : Controller
    {
        IMapper mapper;
        public StoreDbContext Context = new StoreDbContext();
        public IStoreService store;
        public StoreController(StoreDbContext dbcontext,IStoreService store1,IMapper _mapper) 
        { 
            mapper = _mapper;
            Context = dbcontext;
            store = store1;
        }

        public IActionResult Add(StoreDto stored)
        {
            var storring = mapper.Map<Store>(stored);
            store.Add(storring);
            return View(storring);
        }

    }
}
