using AppWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWeb.Services
{
    public interface IStudentService
    {
        List<Student> Get();
        Student Get(string id);
        Student Create(Student student);
        void Update(string id, Student student);
        void Remove(string id);
    }
}
