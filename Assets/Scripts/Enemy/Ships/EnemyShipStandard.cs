using UnityEngine;

public class EnemyShipStandard : EnemyShipTemplate
{
    public Animation ShipDestroyAnimation;
    public EnemyHealth EnemyHealth;

    private void Start()
    {
        EnemyHealth.DieAnimation += DieAnimation;
    }

    private void Update()
    {
      
    }
    public void DieAnimation()
    {
        gameObject.GetComponent<Animation>().Play();
        Debug.Log("Anim");
    }

    private void FixedUpdate()
    {
        EnemyShipMovement();
    }

    public override void EnemyShipMovement()
    { 
        _enemyShipRb.velocity = new Vector2( - _speed, 0);
    }
}


