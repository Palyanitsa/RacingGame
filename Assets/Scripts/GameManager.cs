using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject player;
    public GameObject CompleteLevelUI;

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
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene("Level1");
    }
    
}
