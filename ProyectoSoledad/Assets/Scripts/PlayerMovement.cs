using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerMovement : MonoBehaviour
{
    AudioSource audioSource;

    public float moveSpeed = 5f;

    public Rigidbody2D rb; 

    public Animator animator; 

    Vector2 movement;

    void Start () {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical");

       animator.SetFloat("Horizontal", movement.x);
       animator.SetFloat("Vertical", movement.y);
       animator.SetFloat("Speed", movement.sqrMagnitude);

       if (movement.x != 0 || movement.y != 0){

           if(!audioSource.isPlaying){
               audioSource.Play();
           }

       } else {
           audioSource.Stop();
       }
       
    }

    void FixedUpdate () {
        rb.MovePosition(rb.position + movement * moveSpeed/2 * Time.fixedDeltaTime);
    }
}
