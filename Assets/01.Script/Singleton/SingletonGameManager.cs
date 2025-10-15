using UnityEngine;

public class SingletonGameManager : Singleton<SingletonGameManager>
{
    public int score;

    protected override void Awake()
    {
        base.Awake();
    }

    public void AddScore(int score)
    {
        this.score += score;
        Debug.Log("점수가 올랐습니다. 현재 점수 : " + this.score);
    }
}
