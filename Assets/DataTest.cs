    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("HighScore", 12345);
        PlayerPrefs.Save();
        int best = PlayerPrefs.GetInt("HighScore");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
