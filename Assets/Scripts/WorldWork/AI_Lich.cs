using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Lich : MonoBehaviour
{
    [SerializeField] private float _startCoolDown;
    [SerializeField] private float _curentCoolDown;
    [SerializeField] private TurelWatch _pod;
    [SerializeField] private RoomWork _currentRoom;

    private void FixedUpdate()
    {
        if (_curentCoolDown <= 0)
        {
            _pod.Shoot();
            _curentCoolDown = _startCoolDown;
        }
        else
            _curentCoolDown -= Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "Fire")
        {
            Destroy(gameObject);
            FindObjectOfType<PlayersScores>().AddScore();
            _currentRoom.RemEnimy();
        }
    }
}
