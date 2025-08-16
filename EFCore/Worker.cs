using EFCore.Data;
using EFCore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;

namespace EFCore;

public class Worker(DataContext dataContext) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var stopwatch = Stopwatch.StartNew();

        var users = await dataContext.Users.Where(x => x.Username == "johndoe" && x.FirstName == "John" && x.LastName == "Doe").ToListAsync();

        stopwatch.Stop();
        Console.WriteLine($"Запит до БД виконався за {stopwatch.ElapsedMilliseconds} мс");
    }
}
