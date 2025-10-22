using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private Image fillImage;

    private void OnEnable()
    {
        playerHealth.OnHealthChange += UpdateHealthBar;
    }

    private void OnDisable()
    {
        playerHealth.OnHealthChange -= UpdateHealthBar;
    }

    private void UpdateHealthBar(int current, int max)
    {
        fillImage.fillAmount = (float) current / max;
    }
}
