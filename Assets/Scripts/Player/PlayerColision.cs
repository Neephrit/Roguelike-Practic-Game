using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enimy")
        {
            FindObjectOfType<PlayersScores>().RemoveHealthPoints(1);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            FindObjectOfType<GameOverScreenCs>().NextLvl();
        }
    }
}
