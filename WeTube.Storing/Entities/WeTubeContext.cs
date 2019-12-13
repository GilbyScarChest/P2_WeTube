using Microsoft.EntityFrameworkCore;

namespace WeTube.Storing.Entities
{
  public class WeTubeContext : DbContext
  {
    public DbSet<SUsers> Users { get; set; }
    public DbSet<SComments> Comments { get; set; }
    public DbSet<SYTMedia> YTMedia { get; set; }
  }
}