using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    private Rigidbody2D body;
    public float horizontal;
    public float vertical;

    private float moveLimiter = 0.7f;

    public float runSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
         body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
