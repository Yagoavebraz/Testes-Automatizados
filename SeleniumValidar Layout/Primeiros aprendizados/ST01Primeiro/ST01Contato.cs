using NUnit.Framework;
using NUnit.Core;

namespace SeleniumTests
{
    public class ST01Contato
    {
        [Suite] public static TestSuite Suite
        {
            get
            {
                TestSuite suite = new TestSuite("ST01Contato");
                suite.Add(new Criando primeiro script sem programação());
                return suite;
            }
        }
    }
}
