using UnityEngine;

public class EnemyShipStandard : EnemyShipTemplate
{
    private void FixedUpdate()
    {
        EnemyShipMovement();
    }

    public override void EnemyShipMovement()
    { 
        _enemyShipRb.velocity = new Vector2( - _speed, 0);
    }
}


