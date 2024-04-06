using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject _fireBall;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)) //поменять на inputAxis
            Shoot();
    }
    private void Shoot()
    {
        Instantiate(_fireBall,transform.position,transform.rotation);
    }
}
