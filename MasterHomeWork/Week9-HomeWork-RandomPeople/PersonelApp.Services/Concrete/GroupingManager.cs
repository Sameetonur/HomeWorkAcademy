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
        var people = await _context.Persons.Where(p => p.GroupId == null).ToListAsync();
        var groups = new List<Group>();

        var shuffledPeople = people.OrderBy(x => Guid.NewGuid()).ToList();
        var groupCount = (int)Math.Ceiling(shuffledPeople.Count / (double)groupSize);

        for (int i = 0; i < groupCount; i++)
        {
            var group = new Group
            {
                Name = $"Group {i + 1}",
            };

            var groupMembers = shuffledPeople
                .Skip(i * groupSize)
                .Take(groupSize)
                .ToList();

            foreach (var person in groupMembers)
            {
                person.Group = group;
            }

            groups.Add(group);
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

