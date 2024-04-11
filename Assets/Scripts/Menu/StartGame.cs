using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject RecordWindow;
    [SerializeField] private GameObject HelpWindow;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
    public void SetStartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void CloseGame()
    {
        Application.Quit();
    }
    public void WindowOfRecords(bool state)
    {
        RecordWindow.SetActive(state);
    }
    public void WindowOfHelp(bool state)
    {
        HelpWindow.SetActive(state);
    }
}
