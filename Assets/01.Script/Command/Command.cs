using UnityEngine;

public interface IWeaponCommand
{
    void Execute();
}

public class ReloadGunCommand : IWeaponCommand
{
    private Gun gun;

    public void Execute()
    {
        gun.Reload();
    }

    public ReloadGunCommand(Gun gun)
    {
        this.gun = gun;
    }
}

public class ShootGunCommand : IWeaponCommand
{
    private Gun gun;

    public void Execute()
    {
        gun.Shoot();
    }

    public ShootGunCommand(Gun gun)
    {
        this.gun = gun;
    }
}

public class StabKnifeCommand : IWeaponCommand
{
    private Knife knife;

    public void Execute()
    {
        knife.Stab();
    }

    public StabKnifeCommand(Knife knife)
    {
        this.knife = knife;
    }
}
