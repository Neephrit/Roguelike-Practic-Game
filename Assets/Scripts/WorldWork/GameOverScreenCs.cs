using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreenCs : MonoBehaviour
{
    public bool _isDead;
    [SerializeField] private GameObject Panel;

    private void Awake()
    {
        _isDead = false;
    }

    public void Dead()
    {
        _isDead = true;
    }

    private void Update()
    {
        Panel.SetActive(_isDead);

        if (Input.GetKeyDown(KeyCode.Space) && _isDead) 
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1f;
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1f;
        }
    }
}
