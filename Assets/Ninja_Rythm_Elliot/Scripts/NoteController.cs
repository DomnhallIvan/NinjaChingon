using UnityEngine;

public class NoteController : MonoBehaviour
{
    //private GameController gameController;
    public NoteScoreManager noteScoreManager;
    public List_Of_Effects Efectos;
    public PlayerAnim myAnimationController;
    public BossAnim myAnimationControllerBoss;
    public PlaySoundButton _playS;

    private bool hasCollideEX = false;

    void Start()
    {
        noteScoreManager = GameObject.FindObjectOfType<NoteScoreManager>();
        Efectos = GameObject.FindObjectOfType<List_Of_Effects>();
        myAnimationController = GameObject.FindObjectOfType<PlayerAnim>();
        myAnimationControllerBoss = GameObject.FindObjectOfType<BossAnim>();
        _playS = GameObject.FindObjectOfType<PlaySoundButton>();

    }

    private void FalseAgain()
    {
        hasCollideEX = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        // Si la nota colisiona con el jugador, destrúyela
        if (other.CompareTag("PlayerEX"))
        {
            if(hasCollideEX==false)
            {
                hasCollideEX = true;
                Efectos.DeluxyCombo(1);
                Efectos.NoteStatus.text = "Excelent";
                Efectos.NoteStatus.color = new Color(0, 219, 255);
                LeanTween.scale(Efectos.NoteStatus.gameObject, new Vector3(1.5f, 1.5f, 1.5f), 0.5f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic);
                LeanTween.scale(Efectos.NoteStatus.gameObject, new Vector3(1f, 1f, 1f), 0.5f).setDelay(.5f).setEase(LeanTweenType.easeInOutCubic);
                LeanTween.scale(Efectos.NoteStatus.gameObject, new Vector3(0f, 0f, 0f), 1f).setDelay(1f).setEase(LeanTweenType.easeInOutCubic);
                noteScoreManager.ChangeExScore(100);
                Efectos.Effects[0].Play();

                myAnimationController.Attack();
                myAnimationControllerBoss.Material();
                _playS.PLaythissound();

                Destroy(gameObject);
                Invoke(nameof(FalseAgain), 1f);
            }

        }
        else if (other.CompareTag("PlayerG"))
        {
            if(hasCollideEX==false)
            {
                hasCollideEX = true;
                Efectos.DeluxyCombo(1);
                noteScoreManager.ChangeExScore(100);
                Efectos.NoteStatus.text = "Good";
                Efectos.NoteStatus.color = new Color(255, 0, 228);
                LeanTween.scale(Efectos.NoteStatus.gameObject, new Vector3(1.5f, 1.5f, 1.5f), 0.5f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic);
                LeanTween.scale(Efectos.NoteStatus.gameObject, new Vector3(1f, 1f, 1f), 0.5f).setDelay(.5f).setEase(LeanTweenType.easeInOutCubic);
                LeanTween.scale(Efectos.NoteStatus.gameObject, new Vector3(0f, 0f, 0f), 1f).setDelay(1f).setEase(LeanTweenType.easeInOutCubic);
               // Efectos.Effects[1].Play();

                myAnimationController.Attack();
                myAnimationControllerBoss.Material();
                _playS.PLaythissound();

                Destroy(gameObject);
                Invoke(nameof(FalseAgain), 1f);
            }
            
            
            // gameController.Score();
        }
        else if (other.CompareTag("PlayerMeh"))
        {
            if (hasCollideEX == false)
            {
                hasCollideEX = true;
                Efectos.DeluxyCombo(1);
                Efectos.NoteStatus.text = "Meh";
                Efectos.NoteStatus.color = Color.yellow;
                LeanTween.scale(Efectos.NoteStatus.gameObject, new Vector3(1.5f, 1.5f, 1.5f), 0.5f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic);
                LeanTween.scale(Efectos.NoteStatus.gameObject, new Vector3(1f, 1f, 1f), 0.5f).setDelay(.5f).setEase(LeanTweenType.easeInOutCubic);
                LeanTween.scale(Efectos.NoteStatus.gameObject, new Vector3(0f, 0f, 0f), 0.7f).setDelay(1f).setEase(LeanTweenType.easeInOutCubic);
                noteScoreManager.ChangeExScore(50);
               // Efectos.Effects[2].Play();

                myAnimationController.Attack();
                myAnimationControllerBoss.Material();
                _playS.PLaythissound();


                Destroy(gameObject);
                Invoke(nameof(FalseAgain), 1f);
            }
            
            // gameController.Score();
        }
        else if (other.CompareTag("PlayerBd"))
        {
            if (hasCollideEX == false)
            {
                hasCollideEX = true;
                Efectos.DeluxyCombo(1);
                Efectos.NoteStatus.text = "Bruh";
                Efectos.NoteStatus.color = Color.red;
                LeanTween.scale(Efectos.NoteStatus.gameObject, new Vector3(1.5f, 1.5f, 1.5f), 0.5f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic);
                LeanTween.scale(Efectos.NoteStatus.gameObject, new Vector3(1f, 1f, 1f), 0.5f).setDelay(.5f).setEase(LeanTweenType.easeInOutCubic);
                LeanTween.scale(Efectos.NoteStatus.gameObject, new Vector3(0f, 0f, 0f), 0.7f).setDelay(1f).setEase(LeanTweenType.easeInOutCubic);
                noteScoreManager.ChangeExScore(25);
                //Efectos.Effects[3].Play();
                Destroy(gameObject);
                Invoke(nameof(FalseAgain), 0.1f);
            }
           
            // gameController.Score();
        }

    }
}
