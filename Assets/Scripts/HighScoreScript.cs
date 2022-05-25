using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScoreScript : MonoBehaviour
{
    void Awake()
    {
        gameObject.GetComponent<TMPro.TMP_Text>().text = PlayerPrefs.GetInt("maxScore").ToString();
    }
}
