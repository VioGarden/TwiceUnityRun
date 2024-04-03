using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walnut1 : MonoBehaviour
{
    public GameObject walnutWhole;
    public GameObject walnutShell;

    public bool gotWalnut;

    private void Start()
    {
        walnutWhole.SetActive(true);
        walnutShell.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (!gotWalnut)
            {
                walnutWhole.SetActive(false);
                walnutShell.SetActive(true);
                StatsManager.Instance.globalWalnutCount += 1;
                gotWalnut = true;
            }
        }
    }
}
