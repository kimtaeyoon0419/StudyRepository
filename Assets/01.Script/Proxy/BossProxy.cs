using System.Collections;
using UnityEngine;

public class BossProxy : IBoss
{
    private RealBoss realBoss;
    private bool isLoaded = false;

    public void LoadBoss()
    {
        if (isLoaded) return;

        realBoss = new RealBoss();
        isLoaded = true;
    }

    public void SpawnBoss()
    {
        if(!isLoaded) LoadBoss();

        realBoss.SpawnBoss();
    }
}
