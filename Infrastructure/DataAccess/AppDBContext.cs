using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Application.Extensions.Identity;

namespace Infrastructure.DataAccess
{
    public class AppDBContext(DbContextOptions<AppDBContext> options) : 
        IdentityDbContext<ApplicationUser>(options)
    {
    }
}
