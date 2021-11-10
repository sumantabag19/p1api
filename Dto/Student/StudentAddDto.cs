using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Dto.Student
{
    public partial class StudentAddDto
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int? ClassMasterId { get; set; }

        public virtual ClassMasterAddDto ClassMaster { get; set; }
    }
}
