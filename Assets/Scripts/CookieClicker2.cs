using System;
using UnityEngine;
using UnityEngine.UI;

public class CookieClicker2 : MonoBehaviour {


    bool click;
    public int counter;
    public Text scoreText;
    

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        click = Input.GetKeyDown(KeyCode.C);
        if (click == true) {
            counter += 1;
            if (counter == 10) {
                Debug.Log("You got 10, now activated worker");
                GetComponent<Worker>().enabled = true;
            }
                }
        scoreText.text = "Popped Corn: " + Convert.ToString(counter);
    }
        }
