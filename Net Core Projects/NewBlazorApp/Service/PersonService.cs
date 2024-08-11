using AutoMapper;
using NewBlazorApp.Dto;
using NewBlazorApp.Interface;
using NewBlazorApp.Model;

namespace NewBlazorApp.Service
{
    public class PersonService : IPersonService
    {

        private readonly IPersonRepo personRepo;
        private readonly IMapper _mapper;

        public PersonService(IPersonRepo repo,IMapper mapper) 
        {
            personRepo = repo;
            _mapper = mapper;
        }


        public async Task<IEnumerable<PersonDto>> GetAllPersonsAsync()
        {
            var person = await personRepo.GetAllPersonsAsync();
            return _mapper.Map<IEnumerable<PersonDto>>(person);
        }
        public async Task<PersonDto> GetPersonByIdAsync(int id)
        {
           var person = await personRepo.GetPersonByIdAsync(id);
            return _mapper.Map<PersonDto>(person);
        }
        public async Task AddPersonAsync(PersonDto personDto)
        {
            var person = _mapper.Map<Person>(personDto);
            await personRepo.AddPersonAsync(person);
        }
        public async Task UpdatePersonAsync(PersonDto personDto)
        {
            var person = _mapper.Map<Person>(personDto);
            await personRepo.UpdatePersonAsync(person);
        }
        public async Task DeletePersonAsync(int id)
        {
            await personRepo.DeletePersonAsync(id); 
        }
    }
}
