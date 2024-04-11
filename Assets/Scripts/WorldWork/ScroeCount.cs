using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScroeCount : MonoBehaviour
{
    public static ScroeCount instance;

    [SerializeField] private Text _scoreText;
    [SerializeField] private Text _levelText;
    [SerializeField] private GameObject[] _healthPointImg;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    private void Update()
    {
        _scoreText.text = "Score: " + PlayersScores.SoulsPoint;
        _levelText.text = "Level: " + FindObjectOfType<PlayersScores>().Levels;

        switch (PlayersScores.Instance.HeathPoint)
        {
            default:
                for(int i=0; i<_healthPointImg.Length; i++)
                {
                    _healthPointImg[i].SetActive(false);
                }
                break;
            case 1:
                _healthPointImg[0].SetActive(true);
                _healthPointImg[1].SetActive(false);
                _healthPointImg[2].SetActive(false);
                break;
            case 2:
                _healthPointImg[0].SetActive(true);
                _healthPointImg[1].SetActive(true);
                _healthPointImg[2].SetActive(false);
                break;
            case 3:
                _healthPointImg[0].SetActive(true);
                _healthPointImg[1].SetActive(true);
                _healthPointImg[2].SetActive(true);
                break;
        }
    }
}
