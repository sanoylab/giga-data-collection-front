using gdcp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace gdcp.Data
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User GetById(int? id);
        void Add(User user, string type);
        bool Delete(int id);
    }
}
