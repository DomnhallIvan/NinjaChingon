using UnityEngine;

public class NoteController : MonoBehaviour
{
    //private GameController gameController;
    public NoteScoreManager noteScoreManager;
    public List_Of_Effects Efectos;
    public PlayerAnim myAnimationController;
    public BossAnim myAnimationControllerBoss;
    public PlaySoundButton _playS;

    void Start()
    {
        noteScoreManager = GameObject.FindObjectOfType<NoteScoreManager>();
        Efectos = GameObject.FindObjectOfType<List_Of_Effects>();
        myAnimationController = GameObject.FindObjectOfType<PlayerAnim>();
        myAnimationControllerBoss = GameObject.FindObjectOfType<BossAnim>();
        _playS = GameObject.FindObjectOfType<PlaySoundButton>();

    }

    public void OnTriggerEnter(Collider other)
    {
        // Si la nota colisiona con el jugador, destrúyela
        if (other.CompareTag("PlayerEX"))
        {
            Efectos.DeluxyCombo(1);
            Efectos.NoteStatus.text = "Excelent";
            noteScoreManager.ChangeExScore(100);
            Efectos.Effects[0].Play();
            myAnimationController.Attack();
            myAnimationControllerBoss.Material();
            _playS.PLaythissound();

            Destroy(gameObject);
            // gameController.Score();
        }
        else if (other.CompareTag("PlayerG"))
        {
            Efectos.DeluxyCombo(1);
            noteScoreManager.ChangeExScore(75);
            Efectos.NoteStatus.text = "Good";
            Efectos.Effects[1].Play();
            myAnimationController.Attack();
            myAnimationControllerBoss.Material();
            _playS.PLaythissound();


            Destroy(gameObject);

            // gameController.Score();
        }
        else if (other.CompareTag("PlayerMeh"))
        {
            Efectos.DeluxyCombo(1);
            Efectos.NoteStatus.text = "Meh";
            noteScoreManager.ChangeExScore(50);
            Efectos.Effects[2].Play();
            myAnimationController.Attack();
            myAnimationControllerBoss.Material();
            _playS.PLaythissound();


            Destroy(gameObject);
            // gameController.Score();
        }
        else if (other.CompareTag("PlayerBd"))
        {
            Efectos.DeluxyCombo(1);
            Efectos.NoteStatus.text = "Bruh";
            noteScoreManager.ChangeExScore(25);
            Efectos.Effects[3].Play();


            Destroy(gameObject);
            // gameController.Score();
        }

    }
}
