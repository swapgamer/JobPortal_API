﻿using JobPortal_API.Models;

namespace JobPortal_API.DAL.Repository.Interface
{
    public interface IUserRepo
    {
       
            Task<User> CreateAsync(User user);
            Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task<User> UpdateAsync(int id, User user);
        Task<User> DeleteAsync(int id);
    }
}
