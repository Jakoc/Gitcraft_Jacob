using Microsoft.EntityFrameworkCore;

namespace GitCraft.Controllers;

public class GitCraftContext : DbContext
{
   public DbSet<Character> Character { get; set; }

   public GitCraftContext(DbContextOptions<GitCraftContext> options)
       : base(options)
   {
       
   }
}