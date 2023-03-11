using UnityEngine;

public class LaserBullet : BulletTemplate
{
    private void Start()
    {
        Destroy(gameObject, _lifeTime);
    }

    private void FixedUpdate()
    {
        BulletFlight();
    }

    public override void BulletFlight()
    {
        _bulletRb.velocity = new Vector2(_bulletSpeed, 0);
    }
}
