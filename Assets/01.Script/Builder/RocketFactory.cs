using UnityEngine;

public class RocketFactory : MonoBehaviour
{
    public static RocketFactory instance;
    public Rocket rocketBody;
    public GameObject wings;
    public GameObject nosecone;
    public GameObject engine;
    
    public static Rocket CreateBase()
    {
        if(instance == null)
            instance = FindFirstObjectByType<RocketFactory>();
        var roketBase = Instantiate(instance.rocketBody);
        roketBase.gameObject.AddComponent<BoxCollider>();
        return roketBase;
    }

    public void Falcon()
    {
        var rocket = CreateBase().
            AddWing(wings, 20).
            AddEngine(engine, 45f, 3f).
            AddNosecone(nosecone, 0.05f, 20f);

        rocket.Launch();
    }

    public void Start()
    {
        Falcon();
    }
}
