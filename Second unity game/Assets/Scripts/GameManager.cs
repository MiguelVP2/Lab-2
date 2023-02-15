using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance {get; private set;}

    public GameObject banner;
    public GameObject banner2;
    public GameObject npc;
    public GameObject player;
    public GameObject grassGrower;

    public GameObject dialogBox;
    public TextMeshProUGUI dialogText;

    public int grass = 0;

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

    public void StopGame(){
        npc.GetComponent<EnemyMovement>().StopMoving();
        player.GetComponent<Parrot>().StopMoving();
    }

    public void DialogShow(string text) {
        dialogBox.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(TypeText(text));
    }

    public void DialogHide() {
        dialogBox.SetActive(false);
    }

    IEnumerator TypeText(string text) {
        dialogText.text = "";
        foreach (char c in text.ToCharArray()) {
            dialogText.text += c;
            yield return new WaitForSeconds(0.02f);
        }
    }

    public void reset() {
        DialogHide();
        positionNumber = 0;
        grass = 0;
        banner.SetActive(false);
        banner2.SetActive(false);
        npc.GetComponent<EnemyMovement>().StartMoving();
        player.GetComponent<Parrot>().StartMoving();
        GameObject[] others = GameObject.FindGameObjectsWithTag("grass");
        foreach(GameObject grasses in others) {
            GameObject.Destroy(grasses);
        }
        grassGrower.GetComponent<Photosynthesis>().createGrass();
    }

    public void CountUp(){
        grass++;
        if (grass > 59){
            banner2.SetActive(true);
            StopGame();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        banner.SetActive(false);
        banner2.SetActive(false);
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
        oh = 2.5f;
        oh7 = 5.5f;
        for (int i = 0; i < 10; i++) {
            Vector2 p = new Vector2(oh,oh7);
            posList.Add(p);
            oh7++;
            if (oh7 > 10){
                oh7 = 5.5f;
                oh++;
            }
        }
        oh = 10.5f;
        oh7 = 5.5f;
        for (int i = 0; i < 10; i++) {
            Vector2 p = new Vector2(oh,oh7);
            posList.Add(p);
            oh7++;
            if (oh7 > 10){
                oh7 = 5.5f;
                oh++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
