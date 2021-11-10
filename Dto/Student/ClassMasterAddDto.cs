using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Dto.Student
{
    public partial class ClassMasterAddDto
    {
        public int ClassMasterId { get; set; }
        public string ClassName { get; set; }

        public virtual ICollection<StudentAddDto> Students { get; set; }
    }
}
