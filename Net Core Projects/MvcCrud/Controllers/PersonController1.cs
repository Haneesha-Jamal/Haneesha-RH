using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MvcCrud.DAL;
using MvcCrud.Dto;
using MvcCrud.Interface;
using MvcCrud.Models;

namespace MvcCrud.Controllers
{
    public class PersonController1 : Controller
    {
        IMapper _mapper;
        PersonDBContext  dBContext = new PersonDBContext();
        IService servic;

       public PersonController1(IService servicee, PersonDBContext Context,IMapper mapper)
        {
            dBContext = Context;
            servic = servicee;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult AddPerson(PersonDto person)
        {
            var map = _mapper.Map<Person>(person);
            servic.AddPerson(map);
            return View(map);
        }

        public IActionResult AddPerson()
        {
            return View();  
        }
    }
}
