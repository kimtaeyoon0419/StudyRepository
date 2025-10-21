using UnityEngine;

public class Gun : CommandWeapon
{
    protected int maxBulletCount;
    protected int curBulletCount;
    protected int reloadCoolTime;
    protected int maxReboundRange;

    public virtual void Shoot()
    {
        Debug.Log("Shoot�� ���� Ŭ�������� ���ǵ��� ����");
    }

    public virtual void Reload()
    {
        Debug.Log("Shoot�� ���� Ŭ�������� ���ǵ��� ����");
    }
}
