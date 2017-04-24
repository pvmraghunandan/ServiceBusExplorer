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
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// Message Encryptor Interface
    /// </summary>
    public interface IMessageEncryptor
    {
        /// <summary>
        /// Encrypts the message payload.
        /// </summary>
        /// <param name="payloadArray">The payload array.</param>
        /// <param name="properties">The properties.</param>
        /// <returns>Encrypted Payload</returns>
        ArraySegment<byte> EncryptMessagePayload(ArraySegment<byte> payloadArray, IDictionary<string, object> properties);

        /// <summary>
        /// Decrypts the message payload.
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <param name="properties">The properties.</param>
        /// <returns>Decrypted Payload</returns>
        ArraySegment<byte> DecryptMessagePayload(Stream stream, IDictionary<string, object> properties);
    }
}