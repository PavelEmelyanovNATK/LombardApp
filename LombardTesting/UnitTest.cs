using LombardApp.Shared.Domain.Utils;
using System;
using Xunit;

namespace LombardTesting
{
    public class UnitTest
    {
        //���� ���������� ������
        [Fact]
        public void PasswordValidTest()
        {
            var input = "Passw0rd";
            var expected = true;
            var actual = Validator.ValidatePassword(input);

            Assert.Equal(expected, actual);
        }

        ///���� ���������� ������
        [Fact]
        public void PasswordInvalidTest()
        {
            var input = "Pass";
            var expected = false;
            var actual = Validator.ValidatePassword(input);

            Assert.Equal(expected, actual);
        }
    }
}
