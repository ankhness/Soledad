using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CambiarEscena : MonoBehaviour
{

    public int sceneBuildIndex;
    
    private void OnTriggerEnter2D(Collider2D other){


        if (other.tag == "Player") {
            print ("Switching Scene to" + sceneBuildIndex);
            SceneManager.LoadScene (sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
