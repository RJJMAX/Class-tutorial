using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_tutorial; 

internal class DuplicateClassCode {

    public int Id { get; set; }
    public string Name { get; set; }
    
    public DuplicateClassCode() { }
    public DuplicateClassCode(string name) : this(1, name) {}
    public DuplicateClassCode(int id, string name) {
        Name = name;
        Id = id;
    }
}
