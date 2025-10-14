using UnityEngine;

public class GoblinFactory : FactoryBase
{
    [SerializeField] private GameObject greenGoblin;
    [SerializeField] private GameObject blueGoblin;

    public override GameObject Create(string type)
    {
        GameObject temp = null;

        if (type == "Green")
        {
            temp = Instantiate(greenGoblin);
        }
        else if(type == "Blue")
        {
            temp = Instantiate(blueGoblin);
        }

        return temp;
    }
}
