using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer_Selfkill : MonoBehaviour
{
    private Vector3 start_pos;
    public float distance = 5;

    // Start is called before the first frame update
    void Start()
    {
        start_pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position - start_pos).magnitude >= distance)
        {
            Destroy(gameObject);
        }
    }
}
