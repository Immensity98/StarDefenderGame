using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _restartButton;
    [SerializeField] private GameObject _gameOverPanel;
    private PlayerHealth PlayerHealth;

    private void Start()
    {
        PlayerHealth = FindObjectOfType<PlayerHealth>();
        PlayerHealth.PlayerIsDead.AddListener(PlayerIsDieReaction);
        _restartButton.SetActive(false);
        _gameOverPanel.SetActive(false);
    }

    public void PlayerIsDieReaction()
    {
        _gameOverPanel.SetActive(true); 
        _restartButton.SetActive(true);
    }
}
