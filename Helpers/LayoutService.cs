using PustokMVC.Contexts;
using PustokMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace PustokMVC.Helpers;

public class LayoutService
{
    PustokDbContext _context { get; }

    public LayoutService(PustokDbContext context)
    {
        _context = context;
    }

    public async Task<Settings> GetSettingsAsync()
        => await _context.Settings.FindAsync(1);
}
