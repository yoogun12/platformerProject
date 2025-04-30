using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HighScore
{
    private const string KEY = "HighScore";


    public static int Load(int stage)
    {
        // stage 1 로 불렀을 때, HighScore_1의 데이터를 불러온다
        return PlayerPrefs.GetInt(KEY + "_" + stage, 0);
    }


    public static void TrySet(int stage, int newScore)
    {
        if (newScore <= Load(stage))
            return;

        //Stage1의 점수를 ( 현재 저장된 점수보다 높을 경우 ) 저장한다.
        PlayerPrefs.SetInt(KEY + "_" + stage, newScore);
        PlayerPrefs.Save();
    }
}

