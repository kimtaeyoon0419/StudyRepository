using UnityEngine;

public class AdapterExample : MonoBehaviour
{
    private void Start()
    {
        JsonCharacterStat jsonData = new JsonCharacterStat { hp = 100, attack = 25, def = 10 };

        ICharacterStat characterStat = new CharacterStatAdapter(jsonData);

        Debug.Log($"HP : {characterStat.health}");
        Debug.Log($"Attack : {characterStat.attack}");
        Debug.Log($"Defense : {characterStat.defense}");
    }
}
