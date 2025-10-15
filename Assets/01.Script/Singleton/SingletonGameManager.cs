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
        Debug.Log("������ �ö����ϴ�. ���� ���� : " + this.score);
    }
}
