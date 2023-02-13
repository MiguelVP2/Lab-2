using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingGrass : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
        Vector2 pos = GameManager.Instance.getPos();
        print("got pos");
        transform.position = new Vector2(pos.x, pos.y);
        print("moved");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
