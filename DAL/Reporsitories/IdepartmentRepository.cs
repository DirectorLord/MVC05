using DAL.Entities;

namespace DAL.Reporsitories;

public interface IdepartmentRepository
{
    IEnumerable<Department> GetAll(bool trackChanges = false);
    Department GetById(int id);
    int Add(Department department);
    int Update(Department department);
    int Delete(Department department);
}
