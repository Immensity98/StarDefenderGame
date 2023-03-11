using UnityEngine;

public class BulletTemplate : MonoBehaviour
{
    [SerializeField] protected Rigidbody2D _bulletRb;
    [SerializeField] protected float _bulletSpeed;
    [SerializeField] protected float _lifeTime;
    [SerializeField] private int Damage;

    public int BulletDamageProperty
    {
        get { return Damage; }
        set { Damage = value; }
    }

    private void Start()
    {    
        Destroy(gameObject, _lifeTime);
    }

    public virtual void BulletFlight()
    {

    }
    
}
