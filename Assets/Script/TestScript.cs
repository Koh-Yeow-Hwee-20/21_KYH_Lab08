using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public GameObject scoreText;
    int Counter= 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.GetComponent<Text>().text = "SpaceBar: " +Counter;
    }

    // Update is called once per frame
    void Update()
    {
        //Display variable on UI
        scoreText.GetComponent<Text>().text = "SpaceBar: " + Counter;
        //Display variable on Console
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("SpaceBar: " + Counter);
            Counter++; 
        }
    }
}
