using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    private int _score;
    public TextMeshProUGUI ScorerUI;

    [SerializeField] private EnemyHealth[] EnemyHealthObjects;

    private void Start()
    {
        EnemyHealthObjects = FindObjectsOfType<EnemyHealth>(true);

        if (EnemyHealthObjects != null)
        {
            for (int i = 0; i < EnemyHealthObjects.Length; i++)
            {
                EnemyHealthObjects[i].IsDie.AddListener(GetPoints);
            }
        }
    }

    private void GetPoints()
    {
        _score += 1;
        ScorerUI.text = _score.ToString();
    }
}
