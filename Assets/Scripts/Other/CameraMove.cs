using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Vector3 _offset;
    private void FixedUpdate()
    {
        transform.position = PlayerMovment.instance.transform.position + _offset;
    }
}
