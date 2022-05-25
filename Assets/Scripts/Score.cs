using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TextCore;

public class Score : MonoBehaviour {

    public Transform player;
    public TMPro.TMP_Text scoreText;
    
    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
