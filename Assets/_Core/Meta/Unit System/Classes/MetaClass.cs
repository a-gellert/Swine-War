using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MetaClass", menuName = "Scriptable Objects/MetaClass")]
public class MetaClass : ScriptableObject
{
    public int classID;
    public string className;
    public string classDescription;
    public TypeEnum classType;
    public int health;
    public float speed;
    public List<MetaAmmo> ammoList = new List<MetaAmmo>();
}
