using UnityEngine;

public class Potion : ItemLeaf
{
    public Potion(string name, Type type) : base(name, type)
    {

    }

    // 여기서 한번 더 재정의 해준다면 ItemLeaf에 있는 Operate는 작동하지 않고 Postion에 있는 Operate가 작동할 것.
    public override void Operate()
    {

    }

    private void UsePotion()
    {

    }
}
