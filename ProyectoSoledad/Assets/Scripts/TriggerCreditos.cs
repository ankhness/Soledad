using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCreditos : MonoBehaviour
{
    Animator myAnimator;

    const string CREDITOS = "creditos";


    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other){


        if (other.tag == "Player") {

            myAnimator.SetTrigger(CREDITOS);
        }
    }

}
