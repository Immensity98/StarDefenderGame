using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] protected GameObject _objectPrefab;
    [SerializeField] protected int _poolSize;
    [SerializeField] protected List<GameObject> _objectsList = new List<GameObject>();
    [SerializeField] private Transform _spawnContainer;

    private void Awake()
    {
        CreatePool(_poolSize);
    }

    private void CreatePool(int poolSize)
    {
        for (int i = 0; i < poolSize; i++)
        {
            CreateObject();
        }
    }

    private void CreateObject(bool ActiveByDefault = false)
    {
        GameObject createdObject = Instantiate(_objectPrefab, _spawnContainer); // ������� ��������� � ����� 0, 0, 0. ���������� � �� ����������!
        createdObject.SetActive(ActiveByDefault);
        _objectsList.Add(createdObject);
    }

    public virtual bool HasFreeElement(out GameObject element)
    {
        foreach (GameObject poolObject in _objectsList)
        {
            if (!poolObject.activeInHierarchy)
            {
                element = poolObject;
                poolObject.SetActive(true);
                return true;
            }
        }

        element = null;
        throw new System.Exception("��� ��������� �������� � ����");
    }
}
