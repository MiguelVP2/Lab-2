using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Photosynthesis : MonoBehaviour
{
    public GameObject grass;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 60; i++){
            Instantiate(grass);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
