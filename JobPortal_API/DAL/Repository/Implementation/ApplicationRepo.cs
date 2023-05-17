using JobPortal_API.DAL.Repository.Interface;
using JobPortal_API.Data;
using JobPortal_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Formats.Asn1;

namespace JobPortal_API.DAL.Repository.Implementation
{
    public class ApplicationRepo:IApplicationRepo
    {
        private ApplicationDbContext dbContext;

        public ApplicationRepo(ApplicationDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }
        public async Task<Application> CreateAsync(Application application)
        {
            await dbContext.Applications.AddAsync(application);
            await dbContext.SaveChangesAsync();
            return application;
        }

        public async Task<List<Application>> GetAllAsync()
        {
           return await dbContext.Applications.ToListAsync(); ;
        }
    }
}
