using gdcp.Data;
using gdcp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gdcp.Service
{
    public class UserService : IUserService
    {
        private readonly GdcpAppDbContext _context;
        public UserService(GdcpAppDbContext context)
        {
            _context = context;
        }

        public void Add(User user, string type)
        {
            if (type.Equals("new"))
            {
                _context.Add(user);
            }
            else
            {
                _context.Update(user);
            }
            _context.SaveChanges();
        }

        public bool Delete(int id)
        {
            var user = _context.Users.FirstOrDefault(user => user.Id == id);
            if (user == null)
            {
                return false;
            }
            _context.Remove(user);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public User GetById(int? id)
        {
            return _context.Users.FirstOrDefault(user => user.Id == id);
        }
    }
}
