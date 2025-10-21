using System.Collections.Generic;
using UnityEngine;

public class CommandManager
{
    private Dictionary<string, IWeaponCommand> commandDic = new Dictionary<string, IWeaponCommand>();

    public void SetCommand(string name, IWeaponCommand command)
    {
        if(commandDic.ContainsKey(name))
        {
            Debug.Log("이미 커맨드 리스트가 포함되어 있음");
            return;
        }
        commandDic[name] = command;
    }

    public void InvokeExecute(string name)
    {
        commandDic[name].Execute();
    }
}
