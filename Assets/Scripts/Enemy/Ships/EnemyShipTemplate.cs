using UnityEngine;

public abstract class EnemyShipTemplate : MonoBehaviour
{
    [SerializeField] protected Rigidbody2D _enemyShipRb;
    [SerializeField] protected float _speed;

    public abstract void EnemyShipMovement();

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }

}
