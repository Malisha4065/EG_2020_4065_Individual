using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace individual.Models
{
    public class Module
    {
        public Module(int id, string moduleCode, string moduleName)
        {
            Id = id;
            ModuleCode = moduleCode;
            ModuleName = moduleName;
        }

        public int Id { get; set; }
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public string? Grade {  get; set; }
        //public ICollection<Student> Students { get; set; }

        


    }
}
