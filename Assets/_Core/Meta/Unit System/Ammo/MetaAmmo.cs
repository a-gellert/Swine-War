using UnityEngine;

[CreateAssetMenu(fileName = "MetaAmmo", menuName = "Scriptable Objects/MetaAmmo")]
public class MetaAmmo : ScriptableObject
{
    public int ammoID;
    public string ammoName;
    public bool isInfinite;
    public Sprite ammoIcon;
    public GameObject ammoPrefab;

}
