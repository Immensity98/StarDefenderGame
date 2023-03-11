using UnityEngine;
using UnityEngine.UI;

public class LaserGun : MonoBehaviour
{
    // ¬озможно по€вление новых видов оружи€. ¬ таком случае тот код послужит шаблоном 

    private float _timer;

    [SerializeField] private Text _bulletsNumberUI;
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private int _bulletsNumber;
    [SerializeField] private float _shotDelay;
    [SerializeField] private Transform _bulletSpawnPosition;
    [SerializeField] private AudioSource _ShotSound;

    public int LaserGunProperty
    {
        get { return _bulletsNumber; }
        set { _bulletsNumber = value; }
    }

    private void Start()
    {
        _bulletsNumberUI.text = _bulletsNumber.ToString();
    }

    private void Update()
    {
        Shoot();
    }

    private void CreateBullet()
    {
        Instantiate(_bulletPrefab, _bulletSpawnPosition.position, Quaternion.identity);
    }

    private void Shoot()
    {
        _timer += Time.deltaTime;

        if (_timer > _shotDelay && _bulletsNumber > 0 && Input.GetKey(KeyCode.X))
        {
            CreateBullet();
            _timer = 0;
            _bulletsNumber -= 1;
            _bulletsNumberUI.text = _bulletsNumber.ToString();
            _ShotSound.Play();
        }
    }
}
