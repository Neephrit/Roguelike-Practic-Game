using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public static Shooting instance;
    [SerializeField] private GameObject _fireBall;

    private void Awake()
    {
        if(instance == null)
            instance = this;
    }
    public void Shoot()
    {
        Instantiate(_fireBall,transform.position,transform.rotation);
    }
}
