using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public event Action<int, int> OnHealthChange;

    [SerializeField] private int currentHealth;
    [SerializeField] private int maxHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            TakeDamage(10);
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            Heal(10);
        }
    }

    public void TakeDamage(int amount)
    {
        currentHealth = Mathf.Max(currentHealth - amount, 0);
        OnHealthChange?.Invoke(currentHealth, maxHealth);
    }

    public void Heal(int amount)
    {
        currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
        OnHealthChange?.Invoke(currentHealth, maxHealth);
    }
}
