using UnityEngine;

public class FacadeTest : MonoBehaviour
{
    private CharacterFacade characterFacade;

    private void Start()
    {
        characterFacade = new CharacterFacade();

        characterFacade.MoveCharacter(new Vector3(1, 0, 0));
        characterFacade.AttackEnemy();
        characterFacade.Defend();
    }
}
