using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGame()
    {
        
        StatsManager.Instance.globalCamoTime = 20.00f;
        StatsManager.Instance.globalHealth = 300;
        StatsManager.Instance.globalSpeed = 40;
        StatsManager.Instance.globalAttackDamage = 10;
        StatsManager.Instance.globalKnockBack = 1f;
        StatsManager.Instance.globalIsDead = false;
        StatsManager.Instance.gameHasStarted = true;
        StatsManager.Instance.globalTimer = 180;
        StatsManager.Instance.globalScore = 0;
        StatsManager.Instance.globalMultiplier = 1;
        StatsManager.Instance.globalWalnutCount = 0;
        //SceneManager.LoadScene("MainMap");

        DoorManager.Instance.doorStates[0] = true;
        DoorManager.Instance.doorStates[1] = true;
        DoorManager.Instance.doorStates[2] = true;
        DoorManager.Instance.doorStates[3] = true;

        WalnutManager.Instance.walnutStates[0] = true;
        WalnutManager.Instance.walnutStates[1] = true;
        WalnutManager.Instance.walnutStates[2] = true;
        WalnutManager.Instance.walnutStates[3] = true;
        WalnutManager.Instance.walnutStates[4] = true;
    }
}
