using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Relais
{
    public static class MessageSerializer
    {
        public static MessageOverSocket Serialize(object anySerializableObject)
        {
            using (var memoryStream = new MemoryStream())
            {
                (new BinaryFormatter()).Serialize(memoryStream, anySerializableObject);
                return new MessageOverSocket { Data = memoryStream.ToArray() };
            }
        }

        public static object Deserialize(MessageOverSocket message)
        {
            using (var memoryStream = new MemoryStream(message.Data))
                return (new BinaryFormatter()).Deserialize(memoryStream);
        }
    }
}
