using UnityEngine;

[CreateAssetMenu(fileName = "TransportEntity", menuName = "DataBase/TransportEntity")]
public class DataBaseEntity : ScriptableObject
{
    public TransportType Type;
    public Sprite Image;
    public string Name;
    public float Weight;
    public float Speed;
}
