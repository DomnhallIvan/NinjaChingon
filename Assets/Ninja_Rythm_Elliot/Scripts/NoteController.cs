using UnityEngine;

public class NoteController : MonoBehaviour
{
    //private GameController gameController;
    public NoteScoreManager noteScoreManager;
    public List_Of_Effects Efectos;

    private bool hasCollide = false;

    void Start()
    {
        noteScoreManager = GameObject.FindObjectOfType<NoteScoreManager>();
        Efectos = GameObject.FindObjectOfType<List_Of_Effects>();
  
    }

    private void LateUpdate()
    {
        hasCollide = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        // Si la nota colisiona con el jugador, destrúyela
        if (other.CompareTag("PlayerEX"))
        {
            if(hasCollide==false)
            {
                hasCollide = true;
                Efectos.DeluxyCombo(1);
                Efectos.NoteStatus.text = "Excelent";
                noteScoreManager.ChangeExScore(100);
                Efectos.Effects[0].Play();

                Destroy(gameObject);
            }

        }
        else if (other.CompareTag("PlayerG"))
        {
            if(hasCollide==false)
            {
                hasCollide = true;
                Efectos.DeluxyCombo(1);
                noteScoreManager.ChangeExScore(75);
                Efectos.NoteStatus.text = "Good";
                Efectos.Effects[1].Play();
                Destroy(gameObject);
            }
            
            
            // gameController.Score();
        }
        else if (other.CompareTag("PlayerMeh"))
        {
            if (hasCollide == false)
            {
                hasCollide = true;
                Efectos.DeluxyCombo(1);
                Efectos.NoteStatus.text = "Meh";
                noteScoreManager.ChangeExScore(50);
                Efectos.Effects[2].Play();
                Destroy(gameObject);
            }
            
            // gameController.Score();
        }
        else if (other.CompareTag("PlayerBd"))
        {
            if (hasCollide == false)
            {
                hasCollide = true;
                Efectos.DeluxyCombo(1);
                Efectos.NoteStatus.text = "Bruh";
                noteScoreManager.ChangeExScore(25);
                Efectos.Effects[3].Play();
                Destroy(gameObject);
            }
           
            // gameController.Score();
        }

    }
}
