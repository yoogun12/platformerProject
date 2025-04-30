using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HighScore
{
    private const string KEY = "HighScore";


    public static int Load(int stage)
    {
        // stage 1 �� �ҷ��� ��, HighScore_1�� �����͸� �ҷ��´�
        return PlayerPrefs.GetInt(KEY + "_" + stage, 0);
    }


    public static void TrySet(int stage, int newScore)
    {
        if (newScore <= Load(stage))
            return;

        //Stage1�� ������ ( ���� ����� �������� ���� ��� ) �����Ѵ�.
        PlayerPrefs.SetInt(KEY + "_" + stage, newScore);
        PlayerPrefs.Save();
    }
}

