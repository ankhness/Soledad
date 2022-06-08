using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TriggerEnte: MonoBehaviour
{
    Animator myAnimator;

    const string RUGIDO_ANIM = "rugido";
    const string CREDITOS = "creditos";

    public AudioSource emisor;

    public AudioClip sonido; 

    public AudioSource emisor2;

    public AudioClip sonido2;

    public float volumen;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other){


        if (other.tag == "Player") {
            
            myAnimator.SetTrigger(RUGIDO_ANIM);
            emisor.PlayOneShot(sonido,volumen);
            emisor2.PlayOneShot(sonido2,volumen);
            myAnimator.SetTrigger(CREDITOS);
        }
    }

}
