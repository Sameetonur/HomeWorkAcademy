using System;
using PersonelApp.Entity.Concrete;

namespace PersonelApp.Services.Abstract;

public interface IGroupingService
{
    Task<List<Group>> CreateGroupsAsync(int groupSize);
    Task SaveGroupsAsync();
    Task DeleteAllGroupsAsync();

}
