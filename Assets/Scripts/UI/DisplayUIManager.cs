using UnityEngine;
using UnityEngine.UI;

public class DisplayUIManager : MonoBehaviour
{
    [SerializeField] private HealthUI _healthUI;
    [SerializeField] private PlayerHealth _playerHealth;
    [SerializeField] private Text _scoreUI;
    private void Start()
    {
        _healthUI.CreateHealth(_playerHealth.PlayerHealthProperty);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
