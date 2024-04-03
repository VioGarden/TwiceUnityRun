using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class YourScore : MonoBehaviour
{
    public TextMeshProUGUI baseGlobalScore;
    public float baseGlobalScoreValue;
    public TextMeshProUGUI baseMultiplier;
    public float baseMultiplierValue;
    public TextMeshProUGUI bonusCamoScore;
    public float bonusCamoScoreValue;
    public TextMeshProUGUI bonusHealthScore;
    public int bonusHealthScoreValue;
    public TextMeshProUGUI bonusADScore;
    public int bonusADScoreValue;
    public TextMeshProUGUI bonusKBScore;
    public float bonusKBScoreValue;
    public TextMeshProUGUI deathPenalty;
    public bool deathPenaltyValue;
    public TextMeshProUGUI timerPenalty;
    public float timerPenaltyValue;
    public TextMeshProUGUI monsterKillCount;
    public int monsterKillCountValue;
    public TextMeshProUGUI monsterKillCountBonus;

    public TextMeshProUGUI walnutsCollected;
    public int walnutsCollectedValue;
    public TextMeshProUGUI walnutsCollectedMultiplier;

    public TextMeshProUGUI finalScore;

    public TextMeshProUGUI finalScoreValue;
    public float finalScoreValueValue;

    //TO DO LIST
    // FINISH END SCENE
    // MAP IMAGES ALL OVER MAIN MAP
    // INSTRUCTIONS SOMEWHERE
    // BUG SEARCHING
    // MAYBE DECORATE END SCENE



    private void Start()
    {
        baseGlobalScoreValue = StatsManager.Instance.globalScore;
        baseMultiplierValue = StatsManager.Instance.globalMultiplier;
        bonusCamoScoreValue = StatsManager.Instance.globalCamoTime;
        bonusHealthScoreValue = StatsManager.Instance.globalHealth;
        bonusADScoreValue = StatsManager.Instance.globalAttackDamage;
        bonusKBScoreValue = StatsManager.Instance.globalKnockBack;
        deathPenaltyValue = StatsManager.Instance.globalIsDead;
        timerPenaltyValue = StatsManager.Instance.globalTimer;
        //monsterKillCountValue = StatsManager.Instance
        walnutsCollectedValue = StatsManager.Instance.globalWalnutCount;
        finalScoreValueValue = 0f;
        UpdateScoreDisplay();
    }



    private void UpdateScoreDisplay()
    {
        //string finalScoreString = "Final Score : " + string.Format("{0:0.00}", finalScoreValue);
        //finalScoreText.text = finalScoreString;

        //string finalWalnutScoreString = "You collected " + finalWalnutScoreValue + "Walnuts";
        //finalWalnutScoreText.text = finalWalnutScoreString;
    }
}
