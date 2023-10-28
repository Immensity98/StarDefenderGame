using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShotsBonus : BonusTemplate
{
    private LaserGun LaserGun;

    [SerializeField] private TextMeshProUGUI _bulletsNumberUI;
    [SerializeField] private int GetBulletsValue;

    private void Start()
    {
        LaserGun = FindObjectOfType<LaserGun>(); // только если LaserGun у одного объекта
    }

    public override void GetBonus()
    {
        LaserGun.LaserGunProperty += GetBulletsValue;
        _bulletsNumberUI.text = LaserGun.LaserGunProperty.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
        {
            GetBonus();
            gameObject.SetActive(false);
            _currentLifeTime = _lifeTime;
        }
    }
}
