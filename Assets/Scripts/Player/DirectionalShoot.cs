using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalShoot : MonoBehaviour
{
    protected float horisontal;
    protected float vertical;

    private void Update()
    {
        horisontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");


        if (vertical < 0 && horisontal == 0 ) //down
            transform.rotation = Quaternion.Euler(180 * Vector3.forward);
        else if (vertical > 0 && horisontal == 0) // up
            transform.rotation = Quaternion.Euler(0 * Vector3.forward);
        else if (horisontal > 0 && vertical == 0) //right
            transform.rotation = Quaternion.Euler(270 * Vector3.forward);
        else if (horisontal < 0 && vertical == 0) //left
            transform.rotation = Quaternion.Euler(90 * Vector3.forward);

        else if (horisontal > 0 && vertical > 0) //right up
            transform.rotation = Quaternion.Euler(315 * Vector3.forward);
        else if (horisontal < 0 && vertical < 0) //left down
            transform.rotation = Quaternion.Euler(135 * Vector3.forward);
        else if (horisontal > 0 && vertical < 0) //right down
            transform.rotation = Quaternion.Euler(225 * Vector3.forward);
        else if (horisontal < 0 && vertical > 0) //left up
            transform.rotation = Quaternion.Euler(45 * Vector3.forward);

    }
}
