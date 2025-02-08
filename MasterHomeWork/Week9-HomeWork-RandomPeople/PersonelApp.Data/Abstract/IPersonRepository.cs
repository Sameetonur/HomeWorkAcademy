using System;
using PersonelApp.Entity.Concrete;

namespace PersonelApp.Data.Abstract;

public interface IPersonRepository
{

    Task<List<Person>> GetAllAsync();
    Task<Person> GetByIdAsync(int id);
    Task AddAsync(Person person);
    Task UpdateAsync(Person person);
    Task DeleteAsync(int id);

}
