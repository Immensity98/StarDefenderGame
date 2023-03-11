using UnityEngine;

public class HealthBonus : BonusTemplate
{
    private PlayerHealth playerHealth;
    private HealthUI _healthUI;

    private void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
        _healthUI = FindObjectOfType<HealthUI>();
        _currentLifeTime = _lifeTime;
    }

    public override void GetBonus()
    {
        playerHealth.PlayerHealthProperty += 1;
        _healthUI.AddHealthUI(playerHealth.PlayerHealthProperty);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerHealth>())
        {
            GetBonus();
            gameObject.SetActive(false);
            _currentLifeTime = _lifeTime;
        }
    }
}

