using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {
 
    public void Quit()
    {
        Debug.Log("Quit");
        SceneManager.LoadScene("Menu");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //Application.Quit();
    }

}
