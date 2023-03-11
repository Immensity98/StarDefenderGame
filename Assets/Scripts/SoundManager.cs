using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource _mainTheme;

    private void Start()
    {    
        _mainTheme.Play();
    }
}