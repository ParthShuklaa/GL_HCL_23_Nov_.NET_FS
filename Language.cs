using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstraction_in_OOP
{
     abstract internal class Language
    {
       public abstract void LanguageName();
    }

    class English: Language
    {
        public override void LanguageName()
        {
            Console.WriteLine("name of the Language is English");
        }
    }

    class Sanskrit : Language
    {
        public override void LanguageName()
        {
            Console.WriteLine("Language is Sanskrit");

        }
    }

    class Telgu : Language
    {
        public override void LanguageName()
        {
            Console.WriteLine("Language is Telgu");
        }
    }
}
