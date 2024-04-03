using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walnut : MonoBehaviour
{
    public GameObject[] walnuts;

    public string[] walnutNames;

    public bool[] walnutStates;

    private void Start()
    {
        walnutStates = WalnutManager.Instance.walnutStates;

        walnutNames = WalnutManager.Instance.walnutNames;

        walnuts = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            walnuts[i] = transform.GetChild(i).gameObject;
        }

        for (int j = 0; j < walnuts.Length; j++)
        {
            Transform walnutTransform = walnuts[j].transform;

            if (walnutStates[j])
            {
                walnutTransform.GetChild(0).gameObject.SetActive(true);
                walnutTransform.GetChild(1).gameObject.SetActive(false);
            }
            else
            {
                walnutTransform.GetChild(0).gameObject.SetActive(false);
                walnutTransform.GetChild(1).gameObject.SetActive(true);
            }
        }
    }

    public void toggleAWalnut(int index)
    {
        Transform walnutTransform = walnuts[index].transform;
        walnutTransform.GetChild(0).gameObject.SetActive(false);
        walnutTransform.GetChild(1).gameObject.SetActive(true);
    }
}
