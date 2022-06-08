using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PuertaSFXTrigger : MonoBehaviour
{
    public AudioSource emisorSonido;

    public AudioClip sonidoAEmitir; 

    public float volumen;

    private void OnTriggerEnter2D(Collider2D other){
        

        if (other.tag == "Player") {
            
            emisorSonido.PlayOneShot(sonidoAEmitir,volumen);
        }
    }
}
