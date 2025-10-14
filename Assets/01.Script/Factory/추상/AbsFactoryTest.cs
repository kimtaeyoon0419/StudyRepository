using UnityEngine;

public class AbsFactoryTest : MonoBehaviour
{
    [SerializeField] private AbsBossFactory absBossFactory;

    private void Start()
    {
        absBossFactory.CreateBoss();
    }
}
