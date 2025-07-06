using Microsoft.EntityFrameworkCore;
using SalaryBlazorApp.Repository.Data;
using SalaryBlazorApp.Repository.Models;
using System.Collections.Generic;

namespace SalaryBlazorApp.Repository.Services
{
    public class MenuService : IMenuService
    {
        private readonly AppDbContext _context;

        public MenuService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<MenuItem>> GetMenuHierarchyAsync()
        {
            var allItems = await _context.MenuItem
                .Where(m => m.IsActive)
                .OrderBy(m => m.Order)
                .ToListAsync();

            var lookup = allItems.ToLookup(m => m.ParentId);
            List<MenuItem> BuildTree(int? parentId)
            {
                return lookup[parentId]
                    .Select(item => {
                        item.Children = BuildTree(item.Id);
                        return item;
                    })
                    .ToList();
            }

            List<MenuItem> menuItemsTree = BuildTree(null); // Raíz

            return menuItemsTree;
        }
    }
}
