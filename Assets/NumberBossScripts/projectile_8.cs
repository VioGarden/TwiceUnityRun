using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile_8 : MonoBehaviour
{
    public float velocity_mag = 1;
    public float accelortion = 1;

    private Vector3 velocity_vec; // if it can hit the player
    private float start_time = 0;

    // Start is called before the first frame update
    void Start()
    {
        start_time = Time.time;

        velocity_vec = transform.up; // quaterions are just magic trust
        velocity_vec *= velocity_mag;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity_vec * Time.deltaTime * (Time.time - start_time) * accelortion;
    }
}
