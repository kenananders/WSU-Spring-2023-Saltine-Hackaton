using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonData : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        

        if (transform.position.y < -10) //if yPos is less than -10
        {
            Destroy(this.gameObject);
        }
    }

}
