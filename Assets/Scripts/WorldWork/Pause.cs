using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject _pauseWindow;

    private bool _activePause;
    private void Awake()
    {
        _activePause = false;
    }
    private void Update()
    {
       if(Input.GetKeyDown(KeyCode.Escape)) 
            SwitchPause();

        _pauseWindow.SetActive(_activePause);

       if (_activePause || FindObjectOfType<GameOverScreenCs>()._isDead)
            Time.timeScale = 0f;
       else
            Time.timeScale = 1f;
    }

    private void SwitchPause()
    {
        _activePause = !_activePause;
    }
    public void ActivePause()
    {
        _activePause = true;
    }
    public void OffPause()
    {
        _activePause = false;
    }
}
