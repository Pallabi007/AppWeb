using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWeb.Models
{
    public class StudentStoreDatabaseSettings : IStudentStoreDatabaseSettings
    {
        public string StudentCoursesCollectionName { get; set; } = string.Empty;
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
    }
}
