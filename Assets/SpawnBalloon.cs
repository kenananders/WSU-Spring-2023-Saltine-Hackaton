using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalloon : MonoBehaviour
{
    public GameObject balloonPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //Change GetSpaceDown To something more point oriented 
        {
            Vector3 location = new Vector3(Random.Range(-50, 51),Random.Range(10,21), Random.Range(-50,51)); //Change the 5 to somewhere in the air
            Instantiate(balloonPrefab, location, Quaternion.identity); //Learn what Quaternion is 
        }
    }
}
