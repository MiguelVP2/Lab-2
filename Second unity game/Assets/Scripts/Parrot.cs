using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parrot : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D body;
    public float horizontal;
    public float vertical;
    public bool gameStop = false;

    private float moveLimiter = 0.7f;

    public float runSpeed = 5f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        //trail effect
        
    }

    public void StopMoving(){
        gameStop = true;
        body.velocity = new Vector2(0, 0);
    }

    public void StartMoving(){
        gameStop = false;
        transform.position = new Vector2(-3, -1);
    }

    void FixedUpdate() {
        if (horizontal != 0 && vertical != 0) {
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }

        if (!gameStop){
            body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
        }
    }
}
