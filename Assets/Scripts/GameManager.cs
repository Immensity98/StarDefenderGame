using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _restartButton;
    [SerializeField] private GameObject _gameOverPanel;
    private PlayerHealth PlayerHealth;

    public StandardShipPool StandardShipPool;
    public AsteroidPool AsteroidPool;
    public SoundManager SoundManager;
    public BonusSpawner BonusSpawner;
    public ShowBullets ShowBullets;
    public ScorePanel ScorePanel;
    public ShotsBonus ShotsBonus;
    public HealthBonus HealthBonus;

    private void Start()
    {
        PlayerHealth = FindObjectOfType<PlayerHealth>();
        PlayerHealth.PlayerIsDead.AddListener(PlayerIsDieReaction);
        _restartButton.SetActive(false);
        _gameOverPanel.SetActive(false);
        StandardShipPool.gameObject.SetActive(true);
        AsteroidPool.gameObject.SetActive(true);
        SoundManager.gameObject.SetActive(true);
        BonusSpawner.gameObject.SetActive(true);
        ShowBullets.gameObject.SetActive(true);
        ScorePanel.gameObject.SetActive(true);
        HealthBonus.gameObject.SetActive(true);
        ShotsBonus.gameObject.SetActive(true);
    }

    public void PlayerIsDieReaction()
    {
        StandardShipPool.gameObject.SetActive(false);
        AsteroidPool.gameObject.SetActive(false);
        SoundManager.gameObject.SetActive(false);
        BonusSpawner.gameObject.SetActive(false);
        ShowBullets.gameObject.SetActive(false);
        ScorePanel.gameObject.SetActive(false);
        HealthBonus.gameObject.SetActive(false);
        ShotsBonus.gameObject.SetActive(false);

        _gameOverPanel.SetActive(true);
        _restartButton.SetActive(true);
    }
}
