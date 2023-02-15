using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Input;

public class walkingGrass : MonoBehaviour
{

    private bool inGrass = false;
    public GameObject grass_blade;
    public GameObject grass;

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
        anything = pos;
    }

    // Update is called once per frame
    private Vector2 anything;
    void Update()
    {

        if (Input.GetMouseButtonDown(0)){
            if (inGrass){
                GameManager.Instance.CountUp();
                Sword.Sword1.Swinging();
                //Instantiate(grass_blade, GameObject.Find("grass").transform);

                Destroy(gameObject);

                //particle effect
            }
        }
    }
}
