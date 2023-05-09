using Demo.Services;

namespace UnitTestingDemo
{
    public class UnitTest
    {
        [Theory]
        [InlineData("!@@#QWERqwer1234")]
        [InlineData("123QWERTYghjkl8*()")]
        [InlineData("kjniLKMKm8798&*")]
        [InlineData("!@@#QWERqwe&^6r1234")]
        [InlineData("!@@12234#QWERqwer1234")]
        [InlineData("!@@#QWERgqwer1234")]
        public void ReturnTrue(string password)
        {
           
            IIdentityService identityService= new IdentityService();
            var result = identityService.IsPasswordStrong(password);
            Assert.True(result);
        }
        [Theory]
        [InlineData("12345QWERTYUasdfg")]
        [InlineData("12345QWERTY%^&*")]
        [InlineData("&*&*(QWERTYUasdfg")]
        [InlineData("12345&*(asdfg")]
        [InlineData("!1Qw")]
        public void ReturnFalse(string password)
        {
            IIdentityService identityService = new IdentityService();
            var result = identityService.IsPasswordStrong(password);
            Assert.False(result);
        }
    }
}