using System;
using Microsoft.EntityFrameworkCore;
using PersonelApp.Data.Abstract;
using PersonelApp.Data.Concrete.Context;
using PersonelApp.Entity.Concrete;

namespace PersonelApp.Data.Concrete;

public class PersonRepository : IPersonRepository
{
    
    private PersonelAppDbContext _context;
    public PersonRepository(PersonelAppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Person person)
    {
        await _context.Persons.AddAsync(person);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var person = await GetByIdAsync(id);
        _context.Persons.Remove(person);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Person>> GetAllAsync()
    {
        return await _context.Persons.Include(p => p.Group).ToListAsync();
    }

    public async Task<Person> GetByIdAsync(int id)
    {
        var person = await _context.Persons.FindAsync(id);
        return person!;
    }

    public async Task UpdateAsync(Person person)
    {
        _context.Persons.Update(person);
        await _context.SaveChangesAsync();
    }
}
