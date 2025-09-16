using DAL.Context.Configurations;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Reporsitories;

public class deparmentRepository(CompanyDBContext dbConext) : IdepartmentRepository
{
    private CompanyDBContext _dbContext = dbConext;

    private DbSet<Department> _department = dbConext.Department ; 

    
    public int Add(Department department)
    {
        _department.Add(department);
        return _dbContext.SaveChanges();
    }
    public int Update(Department department) {
        _department.Update(department);
        return _dbContext.SaveChanges();
    }
    public int Delete(Department department) {
        _department.Remove(department);
        return _dbContext.SaveChanges();
    } 
    public IEnumerable<Department> GetAll(bool trackChanges = false) { 
        return trackChanges ? _department.ToList(): _department.AsNoTracking().ToList();
    }
    public Department GetById(int id) {
        return _department.Find(id); 
    }
}
