using UnityEngine;

public class OrkFactory : FactoryBase
{
    [SerializeField] private GameObject redOrk;
    [SerializeField] private GameObject yellowOrk;

    public override GameObject Create(string type)
    {
        GameObject temp = null;

        if(type == "Red")
        {
            temp = Instantiate(redOrk);
        }
        else if(type == "Yellow")
        {
            temp = Instantiate(yellowOrk);
        }

        return temp;
    }
}
