using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteBillboard : MonoBehaviour
{
    Animator anim;
    public Transform target;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        transform.LookAt(target);
        if (transform.position.y + 3 < target.transform.position.y)
        {
            anim.ResetTrigger("above");
            anim.SetTrigger("above");
        } else if (transform.position.y - 3 > target.transform.position.y)
        {
            anim.ResetTrigger("below");
            anim.SetTrigger("below");
        }
        else
        {
            anim.ResetTrigger("equal");
            anim.SetTrigger("equal");
        }
        
    }
}
