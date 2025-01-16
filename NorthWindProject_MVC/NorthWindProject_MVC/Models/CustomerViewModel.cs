using Microsoft.AspNetCore.Mvc.Rendering;

namespace NorthWindProject_MVC.Models
{
    public class CustomerViewModel
    {
        public List<Customers>? Customers { get; set; }

        public SelectList? ContactTitle { get; set; }

        public string? CustomerContactTitle  { get; set; }

        public string? SearchString { get; set; }
    }
}
