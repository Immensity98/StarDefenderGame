using System.Collections.Generic;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private GameObject _healthPrefab;
    [SerializeField] private List<GameObject> _healthListUI = new List<GameObject>();


    public void CreateHealth(int health)
    {
        for (int i = 0; i < health; i++)
        {
            GameObject newHealth = Instantiate(_healthPrefab, transform);
            _healthListUI.Add(newHealth);
        }
    }

    public void DisableHealthUI(int health)
    {
        for (int i = 0; i < _healthListUI.Count; i++)
        {
            if (i >= health)
            {
                _healthListUI[i].SetActive(false);
            }
        }
    }

    public void AddHealthUI(int health)
    {
        for (int i = _healthListUI.Count; i == _healthListUI.Count; i--)
        {
            if (i - 1 > _healthListUI.Count)
            {
                return;
            }

            else if (!_healthListUI[i - 1].activeInHierarchy)
            {
                Debug.Log(i);
                _healthListUI[i - 1].SetActive(true);
                return;
            }
        }
    }
}
