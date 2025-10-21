using UnityEngine;

public class M4A1 : Gun
{
    public override void Shoot()
    {
        Debug.Log("M4A1 발사!");
    }

    public override void Reload()
    {
        Debug.Log("M4A1 장전!");
    }
}
