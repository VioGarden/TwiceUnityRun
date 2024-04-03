using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalnutToggle : MonoBehaviour
{
    public Walnut placeToToggleWalnut;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            string objectName = gameObject.name;
            char lastLetter = objectName[objectName.Length - 1]; // Get the last letter of the string
            int lastLetterAsInt = int.Parse(lastLetter.ToString());
            if (WalnutManager.Instance.walnutStates[lastLetterAsInt])
            {
                WalnutManager.Instance.walnutStates[lastLetterAsInt] = false;
                StatsManager.Instance.globalWalnutCount += 1;
                placeToToggleWalnut.toggleAWalnut(lastLetterAsInt);
            }
            //WalnutManager.Instance.walnutStates[lastLetterAsInt] = false;
            //placeToToggleWalnut.toggleAWalnut(lastLetterAsInt);
        }
    }
}
