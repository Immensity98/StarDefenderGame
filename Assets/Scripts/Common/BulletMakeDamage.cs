using UnityEngine;

public class BulletMakeDamage : MonoBehaviour
{
    private int _bulletDamage;

    private void Start()
    {
        _bulletDamage = gameObject.GetComponent<LaserBullet>().BulletDamageProperty;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<EnemyHealth>(out EnemyHealth _enemyHealthObject))
        {
            _enemyHealthObject.EnemyHealthProperty -= _bulletDamage;
            Destroy(gameObject);
        }
    }
}



