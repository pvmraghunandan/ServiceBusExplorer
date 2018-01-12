// --------------------------------------------------------------------------------------------------------------------
 // <copyright file="AesEncryptor.cs" company="Microsoft"> 
 //   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
 //   IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 //   FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
 //   THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR 
 //   OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
 //   ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR 
 //   OTHER DEALINGS IN THE SOFTWARE. 
 // </copyright>
 // --------------------------------------------------------------------------------------------------------------------
 namespace Microsoft.Azure.ServiceBusExplorer.Helpers
 {
     #region
 
     using System;
     using System.Collections.Generic;
     using System.Diagnostics.CodeAnalysis;
     using System.IO;
     using System.Security.Cryptography;
     using System.Text;
 
     #endregion
 
     /// <summary>
     /// The device metadata encryptor class
     /// </summary>
     public class AesEncryptor : IMessageEncryptor
     {
         /// <summary>
         /// The padding mode
         /// </summary>
         private readonly PaddingMode paddingMode = PaddingMode.PKCS7;
 
         /// <summary>
         /// The AES Crypto key
         /// </summary>
         private byte[] key;
 
         /// <summary>
         /// Sets the key.
         /// </summary>
         /// <param name="aesKey">The aes key.</param>
         public void SetKey(string aesKey)
         {
             this.key = Encoding.UTF8.GetBytes(aesKey);
         }
 
         /// <summary>
         /// Gets or sets the initialization vector.
         /// </summary>
         /// <value>
         /// The initialization vector.
         /// </value>
         public byte[] InitializationVector { get; set; }
 
         /// <summary>
         /// The encrypt payload method
         /// </summary>
         /// <param name="payloadArray">The payload array</param>
         /// <param name="properties">The properties</param>
         /// <returns>Returns encrypted Array segment</returns>
         [SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Justification = "Call to dispose method should not throw ObjectDisposedException")]
         public ArraySegment<byte> EncryptMessagePayload(ArraySegment<byte> payloadArray, IDictionary<string, object> properties)
         {
             var input = payloadArray.Array;
             byte[] encrypted;
 
             using (var aesCryptoServiceProvider = new AesCryptoServiceProvider())
             {
                 aesCryptoServiceProvider.Key = this.key;
 
                 // If initialization vector is null generate a random value
                 if (this.InitializationVector == null)
                 {
    aesCryptoServiceProvider.GenerateIV();
    this.InitializationVector = aesCryptoServiceProvider.IV;
                    }
                 else
                 {
    aesCryptoServiceProvider.IV = this.InitializationVector;
                    }
 
                 aesCryptoServiceProvider.Padding = this.paddingMode;
 
                 using (var encryptor = aesCryptoServiceProvider.CreateEncryptor(aesCryptoServiceProvider.Key, aesCryptoServiceProvider.IV))
                 {
                     //// Create the streams used for encryption. 
                     using (var memsEncrypt = new MemoryStream())
                     {
                         using (var crysEncrypt = new CryptoStream(memsEncrypt, encryptor, CryptoStreamMode.Write))
                         {
                             crysEncrypt.Write(input, 0, input.Length);
                             if (!crysEncrypt.HasFlushedFinalBlock)
                             {
                                 crysEncrypt.FlushFinalBlock();
                             }
 
                             encrypted = memsEncrypt.ToArray();
                             crysEncrypt.Close();
                         }
 
                         memsEncrypt.Close();
                     }
                 }
             }
 
             return new ArraySegment<byte>(encrypted);
         }
 
         /// <summary>
         /// The decrypt method
         /// </summary>
         /// <param name="stream">The stream</param>
         /// <param name="properties">The properties</param>
         /// <returns>Returns decrypted Array Segment</returns>
         [SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Justification = "Call to dispose method should not throw ObjectDisposedException")]
         public ArraySegment<byte> DecryptMessagePayload(Stream stream, IDictionary<string, object> properties)
         {
             var cipherData = new byte[stream.Length];
             stream.Read(cipherData, 0, cipherData.Length);
             byte[] decrypted;
 
             using (var aesCryptoServiceProvider = new AesCryptoServiceProvider())
             {
                 aesCryptoServiceProvider.Key = this.key;
                 aesCryptoServiceProvider.IV = this.InitializationVector;
                 aesCryptoServiceProvider.Padding = this.paddingMode;
 
                 //// Create a decryptor to perform the stream transform.
                 using (var decryptor = aesCryptoServiceProvider.CreateDecryptor(aesCryptoServiceProvider.Key, aesCryptoServiceProvider.IV))
                 {
                     using (var memsDecrypt = new MemoryStream())
                     {
                         using (var crysDecrypt = new CryptoStream(memsDecrypt, decryptor, CryptoStreamMode.Write))
                         {
                             crysDecrypt.Write(cipherData, 0, cipherData.Length);
                             if (!crysDecrypt.HasFlushedFinalBlock)
                             {
                                 crysDecrypt.FlushFinalBlock();
                             }
 
                             decrypted = memsDecrypt.ToArray();
                             crysDecrypt.Close();
                         }
 
                         memsDecrypt.Close();
                     }
                 }
             }
 
             return new ArraySegment<byte>(decrypted);
         }
     }
 }
