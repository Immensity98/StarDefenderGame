using UnityEngine;

public class Asteroid : EnemyShipTemplate
{
    [SerializeField] private float _angularVelocity;
    public AnimationClip AsteroidExplosion;
    private void FixedUpdate()
    {
        EnemyShipMovement();
        transform.Rotate(0, 0, _angularVelocity, Space.Self);
    }
    public override void EnemyShipMovement()
    {
        _enemyShipRb.velocity = new Vector2(0, -_speed);
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
