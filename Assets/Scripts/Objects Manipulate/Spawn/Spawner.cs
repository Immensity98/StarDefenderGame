using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public ObjectPool _objectPool;

    private int currentSpawnPointIndex;
   // private EnemyHealth EnemyHealth;

    [SerializeField] private float _spawnDelay;
    [SerializeField] private GameObject _objectPrefab;
    [SerializeField] private GameObject _spawnPoint;
    [SerializeField] private List<GameObject> _spawnPointList = new List<GameObject>();
    [SerializeField] private int _numberOfPonts;

    private void Awake()
    {
        CreateSpawnPoint();
    }

    public virtual void Start()
    {
        StartCoroutine(SpawnCoroutine());         
    }
    IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            PoolElementActivator();
            yield return new WaitForSeconds(_spawnDelay);
        }
    }

    private void PoolElementActivator()
    {
        if (_objectPool.HasFreeElement(out GameObject element))
        {
            element.SetActive(true);
            SetSpawnPosition(element);

            element.TryGetComponent(out EnemyHealth enemyHealth);
            enemyHealth.EnemyHealthProperty = 2;            // Сделать нормально
        }
    }

    private void CreateSpawnPoint()
    {
        for (int i = 0; i < _numberOfPonts; i++)
        {
            GameObject newPoint = Instantiate(_spawnPoint, gameObject.transform); 
            _spawnPointList.Add(newPoint);
        }
    }

    private void SetSpawnPosition(GameObject ship)
    {
        currentSpawnPointIndex = Random.Range(0, _spawnPointList.Count);
        ship.transform.position = _spawnPointList[currentSpawnPointIndex].transform.position;
    }
}
