using UnityEngine;

public class FactoryTest : MonoBehaviour
{
    [SerializeField] private GoblinFactory goblinFactory;
    [SerializeField] private OrkFactory orkFactory;

    public bool isGreenGoblin;
    public bool isBlueGoblin;
    public bool isRedOrk;
    public bool isGreenOrk; 

    private void Start()
    {
        if(isGreenGoblin) goblinFactory.Create("Green");
        if(isBlueGoblin) goblinFactory.Create("Blue");
        if(isRedOrk) orkFactory.Create("Red");
        if(isGreenOrk) orkFactory.Create("Yellow");
    }
}
