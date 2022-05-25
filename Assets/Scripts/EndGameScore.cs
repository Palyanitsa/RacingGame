using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameScore : MonoBehaviour
{
    void Awake()
    {
        gameObject.GetComponent<TMPro.TMP_Text>().text = PlayerPrefs.GetInt("prevScore").ToString();
    }
}
