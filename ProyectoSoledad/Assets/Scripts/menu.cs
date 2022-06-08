using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
     public GameObject sliderMenu;
   // public Animator animator;
    
   /* public void Inventario(string text)
    {
        sliderInventario.SetActive(true);
        
        
    }*/
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            sliderMenu.GetComponent<Animator>().Play("MenuDentro");
        }

        /* if(Input.GetKeyDown("space")){
            sliderMenu.GetComponent<Animator>().Play("MenuFuera");
            
        }*/
    }
    // Start is called before the first frame update
  /*  public RectTransform subMenu;
    
    float posFinal;
    bool abrirMenu=true;
    public float tiempo=0.5f;


    // Start is called before the first frame update
    void Start()
    {
      posFinal=Screen.width/6;
      subMenu.position = new Vector3 (posFinal + Screen.width+20, subMenu.position.y,0);  
    }
    
    IEnumerator Mover (float time, Vector3 posInit, Vector3 posFin){
        float elapsedTime = 0;
        while (elapsedTime < time){
            subMenu.position = Vector3.Lerp(posInit , posFin , (elapsedTime/time));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        subMenu.position = posFin;
    }
    void MoverMenu (float time, Vector3 posInit, Vector3 posFin){
        StartCoroutine(Mover(time,posInit,posFin));
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape)){
      //  subMenu.gameObject.SetActive(subMenu.gameObject.activeSelf);
       int signo=-1;
        MoverMenu (tiempo, subMenu.position, new Vector3 (signo*(posFinal-(Screen.width/2+948)), subMenu.position.y, 0));
        abrirMenu = !abrirMenu;
      
    }
    }*/
    
}
