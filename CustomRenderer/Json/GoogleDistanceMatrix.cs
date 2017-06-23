using System;
using System.Runtime.Serialization;


    [Serializable]
    [DataContractAttribute]
    public class GoogleDistanceMatrix
    {
        [DataMemberAttribute]
        public string[] destination_addresses;
        [DataMemberAttribute]
        public string[] origin_addresses;
        [DataMemberAttribute]
        public Row[] rows;
        [DataMemberAttribute]
        public string status;
    }