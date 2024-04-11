using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulsBallMove : MonoBehaviour
{
    [SerializeField] private float _forse;
    private void Update()
    {
        transform.Translate(Vector2.up * _forse * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            PlayersScores.Instance.RemoveHealthPoints(1);
        }
        else if (trigger.gameObject.tag == "Door" && trigger.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
