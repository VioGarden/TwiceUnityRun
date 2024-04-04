using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_7 : MonoBehaviour
{
    public float velocity_mag = 1;
    public float velocity_mag_sideways = 1;
    public float period = 1;

    private Vector3 velocity_vec; // if it can hit the player
    private Vector3 velocity_vec_sideways; // if it can hit the player
    private float start_time = 0;

    // Start is called before the first frame update
    void Start()
    {
        start_time = Time.time;

        velocity_vec = transform.up; // quaterions are just magic trust
        velocity_vec *= velocity_mag;

        velocity_vec_sideways = transform.right; // quaterions are just magic trust
        velocity_vec_sideways *= velocity_mag_sideways;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time - start_time + (period / 4.0f)) % period <= period / 2.0f)
        {
            transform.position += velocity_vec_sideways * Time.deltaTime;
        }
        else
        {
            transform.position -= velocity_vec_sideways * Time.deltaTime;
        }
        transform.position += velocity_vec * Time.deltaTime;
    }
}
