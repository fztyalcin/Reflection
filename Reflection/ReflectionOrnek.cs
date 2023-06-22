using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{

    //"Reflection" (yansıma) terimi, bir programın çalışma zamanında kendi yapısını inceleme ve değiştirme yeteneğini ifade eder.
    //Yani, bir nesnenin veya türünün (type) bilgilerine dinamik olarak erişme ve bunları manipüle etme işlemidir.
    //Reflection, C# dilinde geliştiricilere dinamik programlama, metaprogramlama ve veri serileştirme gibi çeşitli senaryolar için güçlü bir araç sağlar.

    public class ReflectionOrnek
    {
        public int Property1 { get; set; }
        public string Property2 { get; set; }

        public void Method1 () 
        {
            Console.WriteLine("Method 1 Called");
        }

        public void Method2 (string parameter)
        {
            Console.WriteLine ("Method 2 Called" +  parameter);
        }

    }
}
