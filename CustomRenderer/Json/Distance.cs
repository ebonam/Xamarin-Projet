using System.Runtime.Serialization;

    [System.Serializable]
    [DataContract]
    public class Distance
    {
        [DataMemberAttribute]
        public int value;
        [DataMemberAttribute]
        public string text;
    }
