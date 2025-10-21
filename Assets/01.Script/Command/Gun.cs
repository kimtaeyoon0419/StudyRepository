using UnityEngine;

public class Gun : CommandWeapon
{
    protected int maxBulletCount;
    protected int curBulletCount;
    protected int reloadCoolTime;
    protected int maxReboundRange;

    public virtual void Shoot()
    {
        Debug.Log("Shoot이 하위 클래스에서 정의되지 않음");
    }

    public virtual void Reload()
    {
        Debug.Log("Shoot이 하위 클래스에서 정의되지 않음");
    }
}
