using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScroeCount : MonoBehaviour
{
    public static ScroeCount instance;

    [SerializeField] private Text _scoreText;
    [SerializeField] private Text _timeText;

    [HideInInspector] public int Score = 0;

    protected float _timeScondF;
    private int _minuteTime = 0;
    private int _secondTime = 0;

    protected string _inputScoreText;
    protected string _inputTimeText;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    private void Update()
    {
        _inputScoreText = "Score: " + Score;
        _scoreText.text = _inputScoreText;

        _timeScondF += Time.deltaTime;
        if (_timeScondF >= 3f)
        { 
            _secondTime++;
            _timeScondF = 0;
        }

        if( _secondTime >= 60 )
        {
            ++_minuteTime;
            _secondTime = 0;
        }

        _inputTimeText = _minuteTime.ToString() + ":" + _secondTime.ToString();
        _timeText.text = _inputTimeText;
    }
}
