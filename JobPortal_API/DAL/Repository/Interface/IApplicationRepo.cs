using JobPortal_API.BLL.DTO;
using JobPortal_API.Models;

namespace JobPortal_API.DAL.Repository.Interface
{
    public interface IApplicationRepo
    {
        Task<Application> CreateAsync(Application application);
        Task<List<Application>> GetAllAsync();
    }
}
