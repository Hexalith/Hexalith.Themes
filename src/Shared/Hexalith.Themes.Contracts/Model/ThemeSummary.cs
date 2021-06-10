namespace Hexalith.ApplicationLayer.Model
{
    using System.Runtime.Serialization;

    using ProtoBuf;

    [ProtoContract]
    [DataContract]
    public class ThemeSummary
    {
        [ProtoMember(2)]
        [DataMember(Order = 1)]
        public string Description { get; set; } = string.Empty;

        [ProtoMember(1)]
        [DataMember(Order = 0)]
        public string Name { get; set; } = string.Empty;
    }
}