using UnityEngine;

public class CharacterStatAdapter : ICharacterStat
{
    private JsonCharacterStat _jsonStats;

    public CharacterStatAdapter(JsonCharacterStat jsonStats)
    {
        _jsonStats = jsonStats;
    }

    public int health => _jsonStats.hp;
    public int attack => _jsonStats.attack;
    public int defense => _jsonStats.def;
}
