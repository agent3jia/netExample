using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TDDExample
{
    public class NaturalNumbersCalcultorTests
    {
        [Fact]
        public void SubtractMethod_Numbers_Success()
        {
            NaturalNumbersCalcultor calcculator = new NaturalNumbersCalcultor();
            int result = calcculator.Substract(4, 3);
            Assert.Equal(1,result);
        }

        [Fact]
        public void SubtractMethod_SecondLargerThanFirst_Success()
        {
            NaturalNumbersCalcultor calcculator = new NaturalNumbersCalcultor();
            int result = calcculator.Substract(4, 5);
            Assert.Equal(0, result);
        }
    }
}
