using UnityEngine;

public class Asteroid : EnemyShipTemplate
{
    [SerializeField] private float _angularVelocity;

    public AnimationClip AsteroidExplosion;
    public EnemyHealth EnemyHealth;

    private void FixedUpdate()
    {
        EnemyShipMovement();
        transform.Rotate(0, 0, _angularVelocity, Space.Self);
    }

    private void Start()
    {

    }

    public void OnIsDie()
    {
           
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
