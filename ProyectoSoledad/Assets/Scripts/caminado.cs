using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caminado : MonoBehaviour
{
    public float velocidad;
    public Vector2 direccion;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        PresionarBotones();
    }

    public void Movimiento(){
        transform.Translate(direccion*velocidad*Time.deltaTime);
       
       if(direccion.x!=0 ||direccion.y!=0){
           AnimarMovimiento(direccion);
       }
       else{
           animator.SetLayerWeight(1,0);
       }

       



    }

    public void PresionarBotones(){

        direccion=Vector2.zero;

        if(Input.GetKey(KeyCode.UpArrow)){
            direccion+=Vector2.up;
        }

        if(Input.GetKey(KeyCode.DownArrow)){
            direccion+=Vector2.down;
        }

        if(Input.GetKey(KeyCode.LeftArrow)){
            direccion+=Vector2.left;
        }

        if(Input.GetKey(KeyCode.RightArrow)){
            direccion+=Vector2.right;
        }

        

    }

    public void AnimarMovimiento(Vector2 direccion)
    {
        animator.SetLayerWeight(1, 1);

        animator.SetFloat("x",direccion.x);
        animator.SetFloat("y",direccion.y);
    }
}
