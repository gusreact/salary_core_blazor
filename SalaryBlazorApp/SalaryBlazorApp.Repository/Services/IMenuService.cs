using SalaryBlazorApp.Repository.Models;

namespace SalaryBlazorApp.Repository.Services
{
    public interface IMenuService
    {
        Task<List<MenuItem>> GetMenuHierarchyAsync();
    }
}
