using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebContactsRedo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<WebContactsRedo.Models.ContactForm> ContactForm { get; set; }
        public DbSet<WebContactsRedo.Models.SelectListItem> SelectListItem { get; set; }
        public DbSet<WebContactsRedo.Models.Order>? Order { get; set; }
    }
}