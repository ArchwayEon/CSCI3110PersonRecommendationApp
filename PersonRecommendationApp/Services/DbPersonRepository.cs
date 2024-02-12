using Microsoft.EntityFrameworkCore;
using PersonRecommendationApp.Models.Entities;

namespace PersonRecommendationApp.Services;

public class DbPersonRepository : IPersonRepository
{
    private readonly ApplicationDbContext _db;

    public DbPersonRepository(ApplicationDbContext db)
    {
        _db = db;
    }
    public async Task<ICollection<Person>> ReadAllAsync()
    {
        return await _db.People.ToListAsync();
    }

    public async Task<Person?> ReadAsync(int id)
    {
        return await _db.People.FindAsync(id);
    }
}
