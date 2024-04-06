using UnityEngine;

public class EnimyFolow : MonoBehaviour
{
    [SerializeField] private Transform _playerPosition;
    [SerializeField] private float _speed;

    private void Awake()
    {
        _playerPosition = FindObjectOfType<PlayerMovment>().GetComponent<Transform>();
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _playerPosition.position,_speed*Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if(trigger.gameObject.tag=="Fire")
        {
            Destroy(gameObject);
            ++ScroeCount.instance.Score;
        }
    }
}
