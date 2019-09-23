using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{

    public string Scene;

   public void OnTriggerEnter2D(Collider2D col)
   {
       if (col.gameObject.tag == "Player")
       {
             SceneManager.LoadScene(Scene);
       }
   }
}
