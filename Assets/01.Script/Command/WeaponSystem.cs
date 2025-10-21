using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    CommandManager commandMgr = new CommandManager();

    private void Start()
    {
        commandMgr = new CommandManager();

        M4A1 m4a1 = new M4A1();
        Knife knife = new Knife();

        ShootGunCommand shootM4a1Command = new ShootGunCommand(m4a1);
        ReloadGunCommand reloadGunCommand = new ReloadGunCommand(m4a1);
        StabKnifeCommand stabKnifeCommand = new StabKnifeCommand(knife);

        commandMgr.SetCommand("leftClick", shootM4a1Command);
        commandMgr.SetCommand("RKey", reloadGunCommand);
        commandMgr.SetCommand("FKey", stabKnifeCommand);
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            commandMgr.InvokeExecute("leftClick");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            commandMgr.InvokeExecute("RKey");
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            commandMgr.InvokeExecute("FKey");
        }
    }
}
