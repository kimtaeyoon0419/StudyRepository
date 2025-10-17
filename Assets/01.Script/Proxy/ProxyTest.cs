using System.Collections;
using UnityEngine;

public class ProxyTest : MonoBehaviour
{
    private BossProxy proxy;

    private IEnumerator Start()
    {
        proxy = new BossProxy();

        proxy.LoadBoss();

        yield return new WaitForSeconds(2f);

        proxy.SpawnBoss();
    }
}
