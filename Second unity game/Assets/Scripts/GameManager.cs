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
        float oh = 0.5f;
        float oh7 = 0.5f;
        positionNumber = 0;
        for (int i = 0; i < 36; i++) {
            Vector2 p = new Vector2(oh,oh7);
            posList.Add(p);
            oh++;
            if (oh > 6){
                oh = 0.5f;
                oh7++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
