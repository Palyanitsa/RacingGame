using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private Animator animator; 

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject player;
    public GameObject CompleteLevelUI;

    public AudioSource aSourse;

    void Start()
    {
        animator = GameObject.FindGameObjectWithTag("QuitButton").GetComponent<Animator>();
        aSourse = gameObject.GetComponent<AudioSource>();
    }


    public void CompleteLevel ()
    {
        CompleteLevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            
            PlayerPrefs.SetInt("prevScore", (int)player.transform.position.z);
            if (PlayerPrefs.GetInt("maxScore")< (int) player.transform.position.z)
            {
                Debug.Log((int)player.transform.position.z);
                PlayerPrefs.SetInt("maxScore", (int) player.transform.position.z);
            }

            animator.SetBool("GameOver", true);
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            //Invoke("Restart", restartDelay);

            aSourse.Play();
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene("Level1");
    }
    
}
