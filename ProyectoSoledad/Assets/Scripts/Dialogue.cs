using System.Collections;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class Dialogue : MonoBehaviour
{
    private bool isPlayerInRange;

    [SerializeField] private GameObject señalDialogo;
    [SerializeField, TextArea(4,6)] private string[] dialogueLines;
    [SerializeField] private TMP_Text dialogueText;

    public AudioSource emisor;
    public AudioClip sonido;
    public float volumen;

    public GameObject CajaDialogo;
    public GameObject Soledad;
    public GameObject Tizon;

    private bool didDialogueStart;
    private int lineIndex;

    private float typingTime = 0.06f;

    // Update is called once per frame
    void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown("space")){
            if(!didDialogueStart){
                StartDialogue();
            } 
            else if (dialogueText.text == dialogueLines[lineIndex]){
                NextDialogueLine();
            }
            else{
                StopAllCoroutines();
                dialogueText.text = dialogueLines[lineIndex];
            }
        }
    }

    private void StartDialogue () {
        didDialogueStart  = true; 
        CajaDialogo.GetComponent<Animator>().Play("DialogosIN");
        Soledad.GetComponent<Animator>().Play("RetratoSIN");
        Tizon.GetComponent<Animator>().Play("RetratoTIN");
        señalDialogo.SetActive(false);
        lineIndex = 0;
        StartCoroutine(ShowLine());
    }

    private void NextDialogueLine() {
        lineIndex++;
        if(lineIndex < dialogueLines.Length){
            StartCoroutine(ShowLine());
        }
        else{
            didDialogueStart = false; 
            CajaDialogo.GetComponent<Animator>().Play("DialogosOUT");
            Soledad.GetComponent<Animator>().Play("RetratoSOUT");
            Tizon.GetComponent<Animator>().Play("RetratoTOUT");
            señalDialogo.SetActive(true);
        }
    }

    IEnumerator ShowLine() {
        dialogueText.text = string.Empty;

        foreach(char ch in dialogueLines[lineIndex]) {
            dialogueText.text += ch;
            yield return new WaitForSeconds (typingTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Player")){
        isPlayerInRange = true;
        señalDialogo.SetActive(true);
        emisor.PlayOneShot(sonido,volumen);
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Player")){
        isPlayerInRange = false;
        señalDialogo.SetActive(false);
        }
    }
}
