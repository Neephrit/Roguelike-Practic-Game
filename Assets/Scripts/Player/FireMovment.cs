using UnityEngine;

public class FireMovment : MonoBehaviour
{
    [SerializeField] private float _forse;

    private void Update()
    {
        transform.Translate(Vector2.up * _forse * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag != "Player" && trigger.gameObject.tag != "Room")
        {
            Destroy(gameObject);
        }
    }
}
