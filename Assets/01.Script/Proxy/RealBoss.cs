using UnityEngine;

public class RealBoss : IBoss
{
    public RealBoss()
    {
        Debug.Log("보스 로딩중 ..");
    }

    public void SpawnBoss()
    {
        Debug.Log("보스 생성!");
    }
}
