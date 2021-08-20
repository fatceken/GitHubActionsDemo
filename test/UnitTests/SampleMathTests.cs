using GitHubActionsDemoApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    public class SampleMathTests
    {

        [Fact]
        public void should_add_given_two_number()
        {
            //Arrange

            var x = 1;
            var y = 2;
            var expected = x + y;

            //Act

            var sut = SampleMath.Add(x, y);

            //Assert

            Assert.Equal(expected, sut);
        }

        [Fact]
        public void should_substract_given_two_number()
        {
            //Arrange

            var x = 1;
            var y = 2;
            var expected = x - y;

            //Act

            var sut = SampleMath.Substract(x, y);

            //Assert

            Assert.Equal(expected, sut);
        }

        [Fact]
        public void should_multiply_given_two_number()
        {
            //Arrange

            var x = 1;
            var y = 2;
            var expected = x * y;

            //Act

            var sut = SampleMath.Multiply(x, y);

            //Assert

            Assert.Equal(expected, sut);
        }

        [Fact]
        public void should_divide_given_two_number()
        {
            //Arrange

            var x = 4;
            var y = 2;
            var expected = x / y;

            //Act

            var sut = SampleMath.Divide(x, y);

            //Assert

            Assert.Equal(expected, sut);
        }

        [Fact]
        public void should_throw_dividebyzeroexception()
        {
            //Arrange

            var x = 4;
            var y = 0;

            //Act

            Action sut = () => SampleMath.Divide(x, y);

            //Assert

            Assert.Throws<DivideByZeroException>(sut);
        }

    }
}
