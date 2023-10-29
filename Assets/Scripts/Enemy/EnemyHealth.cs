using System;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
    public UnityEvent IsDie;

    public Animator animator;

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
            SetDieANim();
        }
    }

    public void Die()
    {
        gameObject.SetActive(false);
        IsDie.Invoke();
    }

    public void SetDieANim()
    {
        animator.SetTrigger("IsDie");
    }
}
