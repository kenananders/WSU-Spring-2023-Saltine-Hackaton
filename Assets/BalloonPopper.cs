/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonPopper : MonoBehaviour
{
    //public GameObject balloonTarget;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(CheckCollision() == true)
            {
                Destroy($$anonymous$$t.collider.gameObject);
                //Destroy(RayCastHit.transform.ballonTarget);
            }
            
        }
    }

    bool CheckCollision()
    {
        Vectors direction = Vector3.forward;
        Ray tempRay = new Ray(transform.position, transform.TransformDirection(direction));

        if (Physics.Raycast(tempRay, out RayCastHit hit)) // may take out RayCastHit?
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
*/