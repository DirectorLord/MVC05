using BLL.DataTransferObject;
using DAL.Reporsitories;

namespace BLL.Services;

public class DepartmentService : IDepartmentService
{
    private IdepartmentRepository _departmentRepository;
    public IDepartmentService departmentService;

    public DepartmentService(IdepartmentRepository idepartmentRepository)
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
