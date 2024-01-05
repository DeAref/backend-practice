using Microsoft.EntityFrameworkCore;

namespace lesson5.Models{
    public class MydbCon:DbContext{
        public MydbCon(DbContextOptions options):base(options){

        }
        public DbSet<plans> plans{get;set;}
        public DbSet<posts> posts{get;set;}
    }
}