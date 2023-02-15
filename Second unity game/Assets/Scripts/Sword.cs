using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    private Rigidbody2D body;
    public GameObject grass_blade;
    public static Sword Sword1;
    
    // Start is called before the first frame update
    void Start()
    {
         body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Swinging()
    {
        Instantiate(grass_blade, Sword1.transform);


    }

    void Awake() {
        if (Sword1 == null) {
            Sword1 = this;
            
            
        }

    }
    
}
