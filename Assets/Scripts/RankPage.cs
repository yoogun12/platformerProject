using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;

public class RankPage : MonoBehaviour
{
    [SerializeField] Transform contentRoot;
    [SerializeField] GameObject rowPrefab;
    [SerializeField] TMP_Text rankText; 

    StageResultList allData;


    private void Awake()
    {
        allData = StageResultServer.LoadRank();
        RefreshRankList(1);
    }
    
    public void SetStageRank(int stage)
    {
        RefreshRankList(stage);
    }

    void RefreshRankList(int _stage)
    {

        if(rankText != null)
        {
            rankText.text = $"stage {_stage} Ranking";
        }

        foreach(Transform child in contentRoot)
        {
            Destroy(child.gameObject);
        }

        var sortedData = allData.results.Where(r => r.stage == _stage).OrderByDescending(x => x.score).ToList();

        for (int i =0; i < sortedData.Count; i++)
        {
            GameObject row = Instantiate(rowPrefab, contentRoot);
            TMP_Text rankText = row.GetComponentInChildren<TMP_Text>();
            rankText.text = $"{i + 1}.{sortedData[i].playerName}-{sortedData[i].score}";
        }
    }

}

