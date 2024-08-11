using NewBlazorApp.Dto;

namespace NewBlazorApp.Interface
{
    public interface IPersonService
    {
        Task<IEnumerable<PersonDto>> GetAllPersonsAsync();
        Task<PersonDto> GetPersonByIdAsync(int id);
        Task AddPersonAsync(PersonDto personDto);
        Task UpdatePersonAsync(PersonDto personDto);
        Task DeletePersonAsync(int id);
    }
}
