using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWeb.Models
{
    public interface IStudentStoreDatabaseSettings
    {
         string StudentCoursesCollectionName { get; set; }
         string ConnectionString { get; set; }
         string DatabaseName { get; set; }
    }
    
}
