using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chest : MonoBehaviour
{

    GameObject Chests;
    int ChestsNum;
    public string Scene;

    // Start is called before the first frame update
    void Start()
    {
        Chests = GameObject.FindWithTag("Chest");
        ChestsNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(ChestsNum == 3)
        {
            SceneManager.LoadScene(Scene);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(Chests);
        ChestsNum = ChestsNum + 1;
    }
}
