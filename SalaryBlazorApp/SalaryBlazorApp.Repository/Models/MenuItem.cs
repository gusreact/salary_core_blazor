using System.ComponentModel.DataAnnotations.Schema;

namespace SalaryBlazorApp.Repository.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Title { get; set; }
        public string? Url { get; set; }
        public string? Icon { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("ParentId")]
        [InverseProperty("Children")]
        public MenuItem? Parent { get; set; }
        [InverseProperty("Parent")]
        public List<MenuItem> Children { get; set; } = new();
    }
}