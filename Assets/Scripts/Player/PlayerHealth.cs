
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private HealthUI HealthUI;
    [SerializeField] private int _health;
    [SerializeField] private int _maxHealth;
    public UnityEvent PlayerIsDead;

    public int PlayerHealthProperty
    {
        get => _health; 
        set => CheckHealth(value);
        
    }

    private void CheckHealth(int value)
    {
        _health = value;
        if (_health > _maxHealth)
        {
            _health = _maxHealth;
            return;
        }

        if (_health <= 0)
        {
            Debug.Log("0");
            PlayerIsDead.Invoke();
            Destroy(gameObject);
        }
    }
}
