using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersScores : MonoBehaviour
{
    public static PlayersScores Instance;
    public ScoreManager scoreManager;

    public int HeathPoint;
    public static int SoulsPoint;
    [HideInInspector]public int Levels;
    [HideInInspector] private bool _isWrite;

    [SerializeField] private int _maxHP;

    private void Awake()
    {
        _isWrite = true;
        HeathPoint = _maxHP;
        LoadScore();
         if (Instance == null)
            Instance = this;
    }
    private void Update()
    {
        if (HeathPoint > 0)
            FindObjectOfType<GameOverScreenCs>()._isDead = false;


        else
        {
            FindObjectOfType<GameOverScreenCs>()._isDead = true;
            SaveRecord();
        }
    }
    public void SaveRecord()
    {
        if (_isWrite)
        {
            scoreManager.AddScore(new ScoreFix("Stranger", PlayersScores.SoulsPoint));
            _isWrite = false;   
        }
            
    }
    public void AddHealthPoints(int sumHP) 
    {
        if(HeathPoint < _maxHP)
            HeathPoint += sumHP; 
    }
    public void RemoveHealthPoints(int damage)
    {
        if(HeathPoint > 0)
            HeathPoint -= damage; 
    }
    public void AddScore() { SoulsPoint++; }
    public void SaveScore() { PlayerPrefs.SetInt("Souls", SoulsPoint); }
    public void LoadScore() { SoulsPoint = PlayerPrefs.GetInt("Souls",0); }
}
