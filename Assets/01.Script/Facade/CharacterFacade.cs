using UnityEngine;

public class CharacterFacade : MonoBehaviour
{
    private Attack _attack;
    private Defense _defense;
    private Movement _movement;

    public CharacterFacade()
    {
        _movement = new Movement();
        _attack = new Attack();
        _defense = new Defense();
    }

    public void MoveCharacter(Vector3 movePostion)
    {
        _movement.Move(movePostion);
    }

    public void AttackEnemy()
    {
        _attack.ExecuteAttack();
    }

    public void Defend()
    {
        _defense.Block();
    }
}
