using System;
using System.Runtime.Serialization;


    [Serializable]
    [DataContractAttribute]
    public class Duration
    {
        [DataMemberAttribute]
        public int value;
        [DataMemberAttribute]
        public string text;
    }
    