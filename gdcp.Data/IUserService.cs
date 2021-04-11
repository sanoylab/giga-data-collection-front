using gdcp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace gdcp.Data
{
    public interface ISchoolService
    {
        IEnumerable<School> GetAll();
        School GetById(int? id);
        void Add(School user, string type);
        bool Delete(int id);
    }
}
