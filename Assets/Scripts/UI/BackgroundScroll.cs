using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [SerializeField] private Transform _currentposition;
    [SerializeField] private float _scrollSpeed;
    [SerializeField] private float _bgSize;

    void Start()
    {
        _currentposition = gameObject.GetComponent<Transform>();
    }
    void Update()
    {
        Move();
    }


    private void Move()
    {
        _currentposition.position = new Vector2(-Mathf.Repeat(Time.time * _scrollSpeed, _bgSize), _currentposition.position.y); 
    }
}
