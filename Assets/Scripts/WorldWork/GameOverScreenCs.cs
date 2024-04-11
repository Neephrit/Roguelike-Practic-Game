using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreenCs : MonoBehaviour
{
    public bool _isDead;
    [SerializeField] private GameObject Panel;
    [SerializeField] private ScoreManager scoreManager;

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
    }

    public void Restart()
    {
        PlayerPrefs.SetInt("Souls", 0);
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
    public void ToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    public void NextLvl()
    {
        PlayersScores.Instance.SaveScore();
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }
}
