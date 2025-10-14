using UnityEngine;

public class FactoryTest : MonoBehaviour
{
    [SerializeField] private GoblinFactory goblinFactory;
    [SerializeField] private OrkFactory orkFactory;

    private void Start()
    {
        goblinFactory.Create("Green");
        goblinFactory.Create("Blue");
        orkFactory.Create("Red");
        orkFactory.Create("Yellow");
    }
}
