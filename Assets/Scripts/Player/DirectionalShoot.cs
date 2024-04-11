using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalShoot : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.Euler(0 * Vector3.forward);
            Shooting.instance.Shoot();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(180 * Vector3.forward);
            Shooting.instance.Shoot();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(90 * Vector3.forward);
            Shooting.instance.Shoot();
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(270 * Vector3.forward);
            Shooting.instance.Shoot();
        }
    }
}
