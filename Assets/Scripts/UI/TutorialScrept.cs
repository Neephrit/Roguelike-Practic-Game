using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScrept : MonoBehaviour
{
    [SerializeField] private GameObject TutorialWindow;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            TutorialWindow.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            TutorialWindow.SetActive(false);
        }
    }
}
