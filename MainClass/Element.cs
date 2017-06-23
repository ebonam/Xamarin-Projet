using System;
using System.Runtime.Serialization;


    [Serializable]
[DataContractAttribute]
public class Element
{
    [DataMemberAttribute]
    public Distance distance;
    [DataMemberAttribute]
    public Duration duration;
    [DataMemberAttribute]
    public string status;
}