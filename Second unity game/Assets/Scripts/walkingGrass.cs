using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Input;

public class walkingGrass : MonoBehaviour
{

    private bool click = false;
    private bool inGrass = false;

    void OnMouseDown(){
        click = true;
    }

    void OnMouseUp(){
        click = false;
    }

    void OnButtonClick(){
        click = true;
    }

    public void OnTriggerEnter2D(Collider2D collider2D) {
        if (collider2D.gameObject.CompareTag("Player")) {
            GetComponent<AudioSource>().Play();
            inGrass = true;

        }
    }

    public void OnTriggerExit2D(Collider2D collider2D) {
        if (collider2D.gameObject.CompareTag("Player")) {
            inGrass = false;
        }
    }

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
        
        // Mouse mouse = Mouse.current;
        // if (mouse.leftButton.wasPressedThisFrame){
        //     click = true;
        // }
        
        if (Input.GetMouseButtonDown(0)){
            if (inGrass){
                GameManager.Instance.CountUp();
                //click = false;
                Destroy(gameObject);
                //particle effect
            }
        }
    }
}
