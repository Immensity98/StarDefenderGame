using UnityEngine;

public class AsteroidPool : ObjectPool
{
    public override bool HasFreeElement(out GameObject element)
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
        throw new System.Exception("Нет свободных обьектов в пуле AsteroidPool");
    }
}
