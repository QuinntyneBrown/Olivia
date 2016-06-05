using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGalleryMicroservice.Services
{
    public interface IEncryptionService
    {
        string TransformPassword(string password);
        string EncryptString(string plainText);
        string DecryptString(string cipherText);
        string EncryptUri(string plainText);
    }
}
