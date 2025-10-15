using UnityEngine;

public class SingletonTest : MonoBehaviour
{
    private void Start()
    {
        SingletonGameManager.Instance.AddScore(10);
    }
}
