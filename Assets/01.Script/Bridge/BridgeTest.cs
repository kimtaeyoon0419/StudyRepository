using UnityEngine;

public class BridgeTest : MonoBehaviour
{
    private Weapon sword;
    private Weapon bow;
    private Weapon axe;

    private void Awake()
    {
        sword = new Sword();
        bow = new Bow();
        axe = new Axe();
    }

    private void Start()
    {
        Debug.Log("검 장착");
        sword.Equipment();
        Debug.Log("검 공격");
        sword.Attack();

        Debug.Log("활 장착");
        bow.Equipment();
        Debug.Log("활 공격");
        bow.Attack();
    }
}
