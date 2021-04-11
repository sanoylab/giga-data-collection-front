using gdcp.Data;
using gdcp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gdcp.Service
{
    public class SchoolService : ISchoolService
    {
        private readonly GdcpAppDbContext _context;
        public SchoolService(GdcpAppDbContext context)
        {
            _context = context;
        }

        public void Add(School School, string type)
        {
            if (type.Equals("new"))
            {
                _context.Add(School);
            }
            else
            {
                _context.Update(School);
            }
            _context.SaveChanges();
        }

        public bool Delete(int id)
        {
            var School = _context.Schools.FirstOrDefault(School => School.Id == id);
            if (School == null)
            {
                return false;
            }
            _context.Remove(School);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<School> GetAll()
        {
            return _context.Schools.Include(a=>a.User);
        }

        public School GetById(int? id)
        {
            return _context.Schools.Include(a => a.User).FirstOrDefault(School => School.Id == id);
        }
    }
}
