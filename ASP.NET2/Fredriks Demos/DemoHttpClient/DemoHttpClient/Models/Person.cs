using System.Runtime.Serialization;

namespace DemoHttpClient.Models
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
