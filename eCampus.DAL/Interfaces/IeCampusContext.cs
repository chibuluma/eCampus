using eCampus.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eCampus.DAL.Interfaces
{
    public interface IeCampusContext 
    {
        DbSet<Country> Countries { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<District> Districts { get; set; }
        DbSet<Gender> Genders { get; set; }
        DbSet<Institution> Institutions { get; set; }
        DbSet<Lecturer> Lecturers { get; set; }
        DbSet<Programme> Programmes { get; set; }
        DbSet<Province> Provinces { get; set; }
        DbSet<School> Schools { get; set; }
        DbSet<Student> Students { get; set; }
        int SaveChanges();
        DbSet<TEntity> Set<TEntity>() where TEntity : class;    
        EntityEntry<TEntity> Add<TEntity>(TEntity entity) where TEntity : class;
        EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : class;
        EntityEntry<TEntity> Update<TEntity>(TEntity entity) where TEntity : class;
}
}