using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance {get; private set;}

    public List<Vector2> posList = new List<Vector2>();

    private int positionNumber;

    void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }

    }

    public Vector2 getPos(){
        print("gamemanager called");
        positionNumber += 1;
        return posList[(positionNumber - 1)];
    }

    public void reset() {
        positionNumber = 0;
    }


    // Start is called before the first frame update
    void Start()
    {
        float oh = 2.5f;
        float oh7 = 3.5f;
        positionNumber = 0;
        for (int i = 0; i < 20; i++) {
            Vector2 p = new Vector2(oh,oh7);
            posList.Add(p);
            oh7++;
            if (oh7 > 5){
                oh7 = 3.5f;
                oh++;
            }
        }
        oh = 2.5f;
        oh7 = 10.5f;
        for (int i = 0; i < 20; i++) {
            Vector2 p = new Vector2(oh,oh7);
            posList.Add(p);
            oh7++;
            if (oh7 > 12){
                oh7 = 10.5f;
                oh++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
