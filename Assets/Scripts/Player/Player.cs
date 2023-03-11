using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerHealth _playerHealth;
    private HealthUI _healthUI;

    [SerializeField] private Rigidbody2D _playerRb;
    [SerializeField] private float _speed;
    [SerializeField] private int _collisionDamageValue;

    [SerializeField] private float _maxYCoordinate;
    [SerializeField] private float _minYCoordinate;
    [SerializeField] private float _maxXCoordinate;
    [SerializeField] private float _minXCoordinate;

    private void Start()
    {
        _healthUI = FindObjectOfType<HealthUI>();
        _playerHealth = GetComponent<PlayerHealth>();
    }

    private void FixedUpdate()
    {
        _playerRb.AddForce(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * _speed);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, _minXCoordinate, _maxXCoordinate),
                                        Mathf.Clamp(transform.position.y, _minYCoordinate, _maxYCoordinate));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out EnemyHealth EnemyObject))
        {
            Debug.Log("sdf");
            EnemyObject.EnemyHealthProperty -= _collisionDamageValue;
            _playerHealth.PlayerHealthProperty -= _collisionDamageValue;
            _healthUI.DisableHealthUI(_playerHealth.PlayerHealthProperty);
        }
    }
}
