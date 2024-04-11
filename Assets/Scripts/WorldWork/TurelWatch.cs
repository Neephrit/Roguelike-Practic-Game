using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurelWatch : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _soulsBall;
    [SerializeField] private float _startCoolDown;
    [SerializeField] private float _curentCoolDown;
    
    
    private void Update()
    {
        Vector3 Look = transform.InverseTransformPoint(_player.transform.position);
        float angle = Mathf.Atan2(Look.y, Look.x) * Mathf.Rad2Deg-90;

        transform.Rotate(0,0,angle);
    }
    public void Shoot()
    {
        Instantiate(_soulsBall, transform.position, transform.rotation);
    }
}
