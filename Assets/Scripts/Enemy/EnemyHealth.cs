using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
    public UnityEvent IsDie;

    [SerializeField] private int _health;

    public int EnemyHealthProperty
    {
        get { return _health; }
        set
        {
            _health = value;
            CheckHealth();
        }
    }

    private void CheckHealth()
    {
        if (_health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        gameObject.SetActive(false);
        IsDie.Invoke();
    }
}
