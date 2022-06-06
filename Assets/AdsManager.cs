using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{
#if UNITY_ANDROID
    string gameId = "4781869";
#else
    string gameId = "4781868";
#endif

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(gameId);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
