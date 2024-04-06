using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonsters : MonoBehaviour
{
    [SerializeField] GameObject monster;
    [SerializeField] private float _startCoolDown;
    private float _coolDown;
    private void Awake()
    {
        _coolDown = _startCoolDown;
    }
    private void Update()
    {
        if(_coolDown > 0)
            _coolDown -= Time.deltaTime;
        else
        {
            Instantiate(monster,transform.position, Quaternion.identity);
            _coolDown = _startCoolDown;
        }
    }
}
