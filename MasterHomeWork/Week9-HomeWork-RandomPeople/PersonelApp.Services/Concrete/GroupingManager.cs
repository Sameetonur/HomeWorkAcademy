using System;
using Microsoft.EntityFrameworkCore;
using PersonelApp.Data.Concrete.Context;
using PersonelApp.Entity.Concrete;
using PersonelApp.Services.Abstract;

namespace PersonelApp.Services.Concrete;

public class GroupingManager : IGroupingService
{

    private readonly PersonelAppDbContext _context;

    public GroupingManager(PersonelAppDbContext context)
    {
        _context = context;
    }
    public async Task<List<Group>> CreateGroupsAsync(int groupSize)
    {
        // 1. Henüz bir gruba atanmamış kişileri getir
        var unassignedPeople = await _context.Persons
            .Where(p => p.GroupId == null)
            .ToListAsync();

        // 2. Kişileri rastgele karıştır
        var random = new Random();
        var randomizedPeople = unassignedPeople
            .OrderBy(x => random.Next())
            .ToList();

        // 3. Kaç grup oluşturulacağını hesapla
        var totalPeople = randomizedPeople.Count;
        var numberOfGroups = totalPeople / groupSize;
        if (totalPeople % groupSize != 0)
            numberOfGroups++;

        // 4. Grupları oluştur
        var groups = new List<Group>();
        var currentPersonIndex = 0;

        for (int groupNumber = 1; groupNumber <= numberOfGroups; groupNumber++)
        {
            // Yeni grup oluştur
            var newGroup = new Group
            {
                Name = "Group " + groupNumber,
                People = new List<Person>()
            };

            // Gruptaki kişi sayısını belirle
            var peopleToAdd = Math.Min(groupSize, randomizedPeople.Count - currentPersonIndex);

            // Kişileri gruba ekle
            for (int i = 0; i < peopleToAdd; i++)
            {
                var person = randomizedPeople[currentPersonIndex];
                person.Group = newGroup;
                newGroup.People.Add(person);
                currentPersonIndex++;
            }

            groups.Add(newGroup);
        }

        return groups;
    }

    public async Task DeleteAllGroupsAsync()
    {
        var people = await _context.Persons.ToListAsync();
        foreach (var person in people)
        {
            person.GroupId = null;
            person.Group = null;
        }
        var groups = await _context.Groups.ToListAsync();
        _context.Groups.RemoveRange(groups);
        await _context.SaveChangesAsync();
    }

    public async Task SaveGroupsAsync()
    {
        await _context.SaveChangesAsync();
    }
}

