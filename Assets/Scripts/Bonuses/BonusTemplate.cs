using UnityEngine;

public abstract class BonusTemplate : MonoBehaviour
{
    [SerializeField] protected GameObject _bonusObject;
    [SerializeField] protected float _rotationSpeed;
    [SerializeField] protected float _lifeTime;
    [SerializeField] protected float _currentLifeTime;
    public abstract void GetBonus();

    private void Start()
    {
        _currentLifeTime = _lifeTime;
    }
    private void Update()
    {
        gameObject.transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
        CheckLifeTime();       
    }

    protected void CheckLifeTime()
    {
        _currentLifeTime -= Time.deltaTime;
        if(_currentLifeTime <= 0)
        {
            _currentLifeTime = _lifeTime;
            gameObject.SetActive(false);
        }
    }
    
}


