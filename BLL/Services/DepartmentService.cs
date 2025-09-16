using BLL.DataTransferObject;
using DAL.Entities;
using DAL.Reporsitories;

namespace BLL.Services;

public class DepartmentService(IRepository<Department> repository) : IDepartmentService
{
    private IDepartmentRepository _departmentRepository;
    public IDepartmentService departmentService;

    public DepartmentService(IDepartmentRepository idepartmentRepository)
    {
        _departmentRepository = idepartmentRepository;
    }

    public DepartmentDetailResponse? GetById(int id)
    {
        return departmentService.GetById(id);
    }

    public IEnumerable<DepartmentDetailResponse> GetAll()
    {
        return departmentService.GetAll();
    }

    public int Update(DepartmentUpdateRequest request)
    {
        return departmentService.Update(request);
    }

    public int Delete(int id)
    {
        return departmentService.Delete(id);
    }

    public int Add(DepartmentRequest request)
    {
        return departmentService.Add(request);
    }
}
