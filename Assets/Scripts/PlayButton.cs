using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
 
 public class PlayButton : MonoBehaviour 
 {
 
       public void LoadSceneOnClick(int sceneNo)
     {
         SceneManager.LoadScene(sceneNo);
     }
 }
