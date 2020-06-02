using Microsoft.EntityFrameworkCore;

namespace HomeschoolHeroes.Models{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options){}
        public DbSet<User>Users{get;set;}
        public DbSet<Teacher>Teachers{get;set;}
        public DbSet<Student>Students{get;set;}
        public DbSet<Subject>Subjects{get;set;}
        public DbSet<Novice>Novices{get;set;}
        public DbSet<Expert>Experts{get;set;}
    }
}