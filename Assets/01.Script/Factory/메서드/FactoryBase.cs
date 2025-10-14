using UnityEngine;

public abstract class FactoryBase : MonoBehaviour
{
    public abstract GameObject Create(string type);
}
