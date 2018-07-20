using System;
using BcAesGcm.Models;

namespace BcAesGcm
{
    public class Crypto
    {
        private ICryptoHelper _helper;
        public Crypto(ICryptoHelper helper)
        {
            _helper = helper;
        }
        public CryptoMessage Encrypt(byte[] privatekey, string message){
            throw new NotImplementedException();
        }
        public string Decrypt(byte[] privateKey, CryptoMessage message){
            throw new NotImplementedException();
        }
    }
}
