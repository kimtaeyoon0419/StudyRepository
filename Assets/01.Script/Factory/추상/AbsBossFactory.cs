using UnityEngine;

public abstract class AbsBossFactory : MonoBehaviour
{
    public Boss CreatBoss()
    {
        Boss boss = new Boss
        {
            bossObject = CreateBoss(),
            weaponObject = CreateWeapon()
        };

        return boss;
    }

    public abstract GameObject CreateBoss();
    public abstract GameObject CreateWeapon();
}
