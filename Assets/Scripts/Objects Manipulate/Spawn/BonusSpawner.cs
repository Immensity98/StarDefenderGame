using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _bonusSpawnPointList = new List<GameObject>();
    [SerializeField] private List<GameObject> _bonusList = new List<GameObject>();

    [SerializeField] private GameObject _bonusSpawnPoint;
    [SerializeField] private int _bonusSpawnPointNumber;
    [SerializeField] private float _bonusSpawnDelay;

    [SerializeField] private float _maxXposition;
    [SerializeField] private float _minXposition;
    [SerializeField] private float _maxYposition;
    [SerializeField] private float _minYposition;
       

    private void Awake()
    {
        CreateSpawnPoint();
    }

    private void Start()
    {
        StartCoroutine(BonusSpawning());
    }

    IEnumerator BonusSpawning()
    {
        while (true)
        {
            yield return new WaitForSeconds(_bonusSpawnDelay);

            BonusSpawn();
        }
    }

    private void BonusSpawn()
    {
        int bonusIndex = Random.Range(0, _bonusList.Count);
        GameObject currentBonus = _bonusList[bonusIndex];

        int spawnPointIndex = Random.Range(0, _bonusSpawnPointList.Count);
        currentBonus.transform.position = _bonusSpawnPointList[spawnPointIndex].transform.position;
        currentBonus.SetActive(true);
    }

    private void CreateSpawnPoint()
    {
        for (int i = 0; i < _bonusSpawnPointNumber; i++)
        {
            _bonusSpawnPointList.Add(Instantiate(_bonusSpawnPoint));
            _bonusSpawnPointList[i].transform.position = new Vector2(Random.Range(_minXposition, _maxXposition), Random.Range(_minYposition, _maxYposition));
        }
    }
}
