using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundReward : MonoBehaviour
{
    public GameObject[] panelsArray; // Array to store the panels

    private void Start()
    {
        // Get all child panels of the parent GameObject
        panelsArray = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            panelsArray[i] = transform.GetChild(i).gameObject;
        }

        for (int j = 0; j < panelsArray.Length; j++)
        {
            if (j == StatsManager.Instance.globalWalnutCount)
            {
                panelsArray[j].SetActive(true);
            }
            else
            {
                panelsArray[j].SetActive(false);
            }
        }
    }
}
