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
    public TextMeshProUGUI bonusSpeedScore;
    public int bonusSpeedScoreValue;
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
        bonusSpeedScoreValue = StatsManager.Instance.globalSpeed;
        bonusADScoreValue = StatsManager.Instance.globalAttackDamage;
        bonusKBScoreValue = StatsManager.Instance.globalKnockBack;
        deathPenaltyValue = StatsManager.Instance.globalIsDead;
        timerPenaltyValue = StatsManager.Instance.globalTimer;
        monsterKillCountValue = StatsManager.Instance.monsterKillCount;
        walnutsCollectedValue = StatsManager.Instance.globalWalnutCount;
        finalScoreValueValue = 0f;
        UpdateScoreDisplay();
    }



    private void UpdateScoreDisplay()
    {
        string baseGlobalScoreString = "<color=#DA8EE7>Base Score : </color> <color=#E8BCF0>" + string.Format("{0:0.00}", baseGlobalScoreValue) + "</color>";
        baseGlobalScore.text = baseGlobalScoreString;

        Color baseGlobalScoreOutlineColor = HexToColor("#000000");
        baseGlobalScore.fontMaterial.EnableKeyword("OUTLINE_ON");
        baseGlobalScore.outlineColor = baseGlobalScoreOutlineColor;
        baseGlobalScore.outlineWidth = 0.1f;

        string baseMultiplierString = "<color=#DA8EE7>Base Multiplier : </color> <color=#E8BCF0>" + string.Format("{0:0.00}", baseMultiplierValue) + "</color>";
        baseMultiplier.text = baseMultiplierString;

        Color baseMultiplierOutlineColor = HexToColor("#000000");
        baseMultiplier.fontMaterial.EnableKeyword("OUTLINE_ON");
        baseMultiplier.outlineColor = baseMultiplierOutlineColor;
        baseMultiplier.outlineWidth = 0.1f;

        string bonusCamoScoreStringVal = bonusCamoScoreValue.ToString("0.00");
        string bonusCamoScoreString = "<color=#19E9E1>Base Camo Bonus:</color> <color=#6FC276>+" + bonusCamoScoreStringVal + "</color>";
        bonusCamoScore.text = bonusCamoScoreString;

        Color bonusCamoScoreOutlineColor = HexToColor("#000000");
        bonusCamoScore.fontMaterial.EnableKeyword("OUTLINE_ON");
        bonusCamoScore.outlineColor = bonusCamoScoreOutlineColor;
        bonusCamoScore.outlineWidth = 0.1f;

        string bonusHealthScoreStringVal = bonusHealthScoreValue.ToString();
        string bonusHealthScoreString = "<color=#A7FFBA>Base Health Bonus:</color> <color=#6FC276>+" + bonusHealthScoreStringVal + "</color>";
        bonusHealthScore.text = bonusHealthScoreString;

        Color bonusHealthScoreOutlineColor = HexToColor("#000000");
        bonusHealthScore.fontMaterial.EnableKeyword("OUTLINE_ON");
        bonusHealthScore.outlineColor = bonusHealthScoreOutlineColor;
        bonusHealthScore.outlineWidth = 0.1f;

        string bonusSpeedScoreStringVal = bonusSpeedScoreValue.ToString();
        string bonusSpeedScoreString = "<color=#F9FD8B>Base Speed Bonus:</color> <color=#6FC276>+" + bonusSpeedScoreStringVal + "</color>";
        bonusSpeedScore.text = bonusSpeedScoreString;

        Color bonusSpeedScoreOutlineColor = HexToColor("#000000");
        bonusSpeedScore.fontMaterial.EnableKeyword("OUTLINE_ON");
        bonusSpeedScore.outlineColor = bonusSpeedScoreOutlineColor;
        bonusSpeedScore.outlineWidth = 0.1f;

        string bonusADScoreStringVal = bonusADScoreValue.ToString();
        string bonusADScoreString = "<color=#F39F38>Base AD Bonus:</color> <color=#6FC276>+" + bonusADScoreStringVal + "</color>";
        bonusADScore.text = bonusADScoreString;

        Color bonusADScoreOutlineColor = HexToColor("#000000");
        bonusADScore.fontMaterial.EnableKeyword("OUTLINE_ON");
        bonusADScore.outlineColor = bonusADScoreOutlineColor;
        bonusADScore.outlineWidth = 0.1f;

        string bonusKBScoreStringVal = bonusKBScoreValue.ToString("0.00");
        string bonusKBScoreString = "<color=#EC9BB0>Base KB Bonus:</color> <color=#6FC276>+" + bonusKBScoreStringVal + "</color>";
        bonusKBScore.text = bonusKBScoreString;

        Color bonusKBScoreOutlineColor = HexToColor("#000000");
        bonusKBScore.fontMaterial.EnableKeyword("OUTLINE_ON");
        bonusKBScore.outlineColor = bonusKBScoreOutlineColor;
        bonusKBScore.outlineWidth = 0.1f;



        string deathTrackerString;
        string deathPenaltyScoreString;
        if (deathPenaltyValue)
        {
            deathTrackerString = "<color=#FF6242>-20%</color>"; // Black color for the string
            deathPenaltyScoreString = "<color=#000000>Death Penalty: </color>" + deathTrackerString;
        }
        else
        {
            deathTrackerString = "<color=#FF6242>-0%</color>"; // Black color for the string
            deathPenaltyScoreString = "<color=#000000>Death Penalty: </color>" + deathTrackerString;
        }
        deathPenalty.text = deathPenaltyScoreString;

        Color deathPenaltyOutlineColor = HexToColor("#000000");
        deathPenalty.fontMaterial.EnableKeyword("OUTLINE_ON");
        deathPenalty.outlineColor = deathPenaltyOutlineColor;
        deathPenalty.outlineWidth = 0.1f;

        string timerPenaltyString;
        if (timerPenaltyValue < 0)
        {
            timerPenaltyString = "<color=#000000>timer left deduction:</color> <color=#FF6242>-0</color>"; // Black for the string, red for the variable
        }
        else
        {
            string timerPenaltyStringVal = timerPenaltyValue.ToString("0.00");
            timerPenaltyString = "<color=#000000>timer left deduction:</color> <color=#FF6242> -" + timerPenaltyStringVal + "</color>"; // Black for the string, red for the variable
        }
        timerPenalty.text = timerPenaltyString;
        Color timerPenaltyOutlineColor = HexToColor("#000000");
        timerPenalty.fontMaterial.EnableKeyword("OUTLINE_ON");
        timerPenalty.outlineColor = timerPenaltyOutlineColor;
        timerPenalty.outlineWidth = 0.1f;

        string monsterKillCountStringVal = monsterKillCountValue.ToString();
        string monsterKillCountString = "<color=#C0C0C0>Monster kill count: </color> <color=#C0C0C0>" + monsterKillCountStringVal + "</color>";
        monsterKillCount.text = monsterKillCountString;

        monsterKillCountBonus.text = "<color=#C0C0C0>Monster Bonus : 5 pts per</color>";

        Color monsterKillCountBonusOutlineColor = HexToColor("#000000");
        monsterKillCountBonus.fontMaterial.EnableKeyword("OUTLINE_ON");
        monsterKillCountBonus.outlineColor = monsterKillCountBonusOutlineColor;
        monsterKillCountBonus.outlineWidth = 0.1f;

        string walnutsCollectedStringVal = monsterKillCountValue.ToString();
        string walnutsCollectedString = "<color=#CD7F32>Walnuts Collected: </color> <color=#CD7F32>" + walnutsCollectedStringVal + "</color>";
        walnutsCollected.text = walnutsCollectedString;

        Color walnutsCollectedOutlineColor = HexToColor("#000000");
        walnutsCollected.fontMaterial.EnableKeyword("OUTLINE_ON");
        walnutsCollected.outlineColor = walnutsCollectedOutlineColor;
        walnutsCollected.outlineWidth = 0.1f;

        walnutsCollectedMultiplier.text = "<color=#CD7F32>Walnut Multiplier : 9.9x per</color>";

        Color walnutsCollectedMultiplierOutlineColor = HexToColor("#000000");
        walnutsCollectedMultiplier.fontMaterial.EnableKeyword("OUTLINE_ON");
        walnutsCollectedMultiplier.outlineColor = walnutsCollectedMultiplierOutlineColor;
        walnutsCollectedMultiplier.outlineWidth = 0.1f;

        finalScore.text = "<color=#FFD700>FINAL SCORE</color>";
        Color finalScoreoutlineColor = HexToColor("#000000");

        finalScore.fontMaterial.EnableKeyword("OUTLINE_ON");
        finalScore.outlineColor = finalScoreoutlineColor;
        finalScore.outlineWidth = 0.1f;

        float finalBaseScoreAdditionAndSubtraction = (baseGlobalScoreValue + bonusCamoScoreValue + bonusHealthScoreValue
            + bonusSpeedScoreValue + bonusADScoreValue + bonusKBScoreValue + 5 * monsterKillCountValue);
        float finalScoreBasePenalty = finalBaseScoreAdditionAndSubtraction - timerPenaltyValue;
        float finalScorePercentagePenalty = finalScoreBasePenalty * 0.8f;
        float finalScorePlusMultiplier = finalScorePercentagePenalty * baseMultiplierValue;
        float finalScoreCountingWalnuts;
        if (walnutsCollectedValue == 0)
        {
            finalScoreCountingWalnuts = finalScorePlusMultiplier;
        }
        else
        {
            finalScoreCountingWalnuts = finalScorePlusMultiplier * walnutsCollectedValue * 9.9f;
        }

        string finalTotalScoreString = "<color=#FFD700>" + finalScoreCountingWalnuts.ToString("0.00") + "</color>";
        finalScoreValue.text = finalTotalScoreString;
        Color finalScoreValueoutlineColor = HexToColor("#FFAE42");

        finalScoreValue.fontMaterial.EnableKeyword("OUTLINE_ON");
        finalScoreValue.outlineColor = finalScoreValueoutlineColor;
        finalScoreValue.outlineWidth = 0.1f;
    }

    Color HexToColor(string hex)
    {
        Color color = Color.white;
        ColorUtility.TryParseHtmlString(hex, out color);
        return color;
    }
}
