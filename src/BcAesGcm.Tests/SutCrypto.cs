using Xunit;
using BcAesGcm;
using Moq;

namespace BcAesGcm.Tests
{
    public class SutCrypto
    {
        [Fact]
        public void EncryptShouldReturnCryptoMessage()
        {
            var mockedHelper = new Mock<ICryptoHelper>();
            Crypto sut = new Crypto(mockedHelper.Object);
        }
    }
}
