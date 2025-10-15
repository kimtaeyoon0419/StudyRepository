using System.Collections;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    private Rigidbody rb;
    private float speed;
    private float power;
    private float airResistance;
    private float fuelStorage;

    public Rocket AddWing(GameObject model, float speed)
    {
        Attach(model);
        this.speed += speed;
        return this;
    }

    public Rocket AddEngine(GameObject model, float power, float storage)
    {
        Attach(model);
        rb = gameObject.AddComponent<Rigidbody>();
        this.power += power;
        this.fuelStorage += storage;
        return this;
    }

    public Rocket AddNosecone(GameObject model, float resistance, float speed)
    {
        Attach(model);
        this.speed += speed;
        this.airResistance += resistance;
        return this;
    }

    public void Launch()
    {
        StartCoroutine(MoveProcess());
    }

    IEnumerator MoveProcess()
    {
        rb.AddExplosionForce(10f, Random.onUnitSphere, 1f);
        while (fuelStorage >= 0)
        {
            fuelStorage -= Time.deltaTime;
            rb.AddForce(power * speed * (airResistance + 1) * Time.deltaTime * Vector3.up);
            yield return null;
        }
    }

    private void Attach(GameObject parts)
    {
        Instantiate(parts).transform.parent = transform;
    }
}