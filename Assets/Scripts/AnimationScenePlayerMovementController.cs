using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScenePlayerMovementController : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rigidbody2D;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector2 dir = new Vector2(h, v);

        rigidbody2D.velocity = dir.normalized * speed;

        
        GetComponent<Animator>().SetBool("isGoingFw", v > 0);
        GetComponent<Animator>().SetBool("isGoingBack", v < 0);

        GetComponent<Animator>().SetBool("isGoingLeft", h < 0);
        GetComponent<Animator>().SetBool("isGoingRigth", h > 0);

    }
}
