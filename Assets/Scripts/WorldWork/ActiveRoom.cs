using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveRoom : MonoBehaviour
{
    [SerializeField] private RoomWork _curentClassRoom;
    [SerializeField] private GameObject _doors;
    [SerializeField] private GameObject _spawners;

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if(trigger.gameObject.tag == "Player")
        {
            _spawners.SetActive(true);
        }
    }
    private void OnTriggerStay2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "Player")
        {
            _doors.SetActive(!_curentClassRoom.CanEscape);
        }
    }
}
