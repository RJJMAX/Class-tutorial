using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_tutorial; 
internal class Test {

    public int Id { get; private set; } = 100;

    public int count = 10;
    public int Count {
        get {
            return count;
        }
        set {
            if(value <= 0) {
                count = value;
            }
        }
    }
    public Test(int i) { }
    public Test() { }
}
