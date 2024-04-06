using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject _pauseText;

    private bool _activePause;
    private void Awake()
    {
        _activePause = false;
    }
    private void Update()
    {
       if(Input.GetKeyDown(KeyCode.LeftShift)) 
            SwitchPause();

        _pauseText.SetActive(_activePause);

       if (_activePause || FindObjectOfType<GameOverScreenCs>()._isDead)
            Time.timeScale = 0f;
       else
            Time.timeScale = 1f;
    }

    private void SwitchPause()
    {
        _activePause = !_activePause;
    }
}
