using System;
using System.Runtime.Serialization;

[Serializable]
[DataContractAttribute]
public class Row
{
    [DataMemberAttribute]
    public Element[] elements;
}