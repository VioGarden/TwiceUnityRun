using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class WalnutManager : MonoBehaviour
{
    public static WalnutManager Instance; // Singleton instance for easy access

    public string[] walnutNames; // Array to store the names of doors

    public bool[] walnutStates;

    public bool walnutStart;

    private void Awake()
    {
        if (Instance != null)
        {
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        if (!walnutStart)
        {
            walnutNames = new string[5];
            walnutNames[0] = "Walnut0";
            walnutNames[1] = "Walnut1";
            walnutNames[2] = "Walnut2";
            walnutNames[3] = "Walnut3";
            walnutNames[4] = "Walnut4";


            walnutStates = new bool[5];
            walnutStates[0] = true;
            walnutStates[1] = true;
            walnutStates[2] = true;
            walnutStates[3] = true;
            walnutStates[4] = true;

            walnutStart = true;
        }
    }

    public void SetWalnut(string walnutName)
    {
        int index = -1; // Initialize index to -1 (not found)

        for (int i = 0; i < walnutNames.Length; i++)
        {
            if (walnutNames[i] == walnutName)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            Debug.Log("DoorNotFound : " + walnutName);
        }
        else
        {
            walnutStates[index] = false;
        }
    }
}
