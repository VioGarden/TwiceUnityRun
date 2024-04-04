using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile_4 : MonoBehaviour
{
    public float velocity_mag = 1;
    public float velocity_mag_square = 1;
    public float period = 1;

    private Vector3 velocity_vec; // if it can hit the player
    private Vector3 velocity_vec_square; // if it can hit the player
    private Vector3 velocity_vec_square_sideways; // if it can hit the player
    private float start_time = 0;

    // Start is called before the first frame update
    void Start()
    {
        start_time = Time.time;

        velocity_vec = transform.up; // quaterions are just magic trust
        velocity_vec *= velocity_mag;

        velocity_vec_square = transform.up; // quaterions are just magic trust
        velocity_vec *= velocity_mag_square;

        velocity_vec_square_sideways = transform.right; // quaterions are just magic trust
        velocity_vec_square_sideways *= velocity_mag_square;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time - start_time) % period <= period / 4.0f)
        {
            transform.position += velocity_vec_square_sideways * Time.deltaTime;
        }
        else if ((Time.time - start_time) % period <= period * 2 / 4.0f)
        {
            transform.position += velocity_vec_square * Time.deltaTime;
        }
        else if ((Time.time - start_time) % period <= period * 3 / 4.0f)
        {
            transform.position -= velocity_vec_square_sideways * Time.deltaTime;
        }
        else
        {
            transform.position -= velocity_vec_square * Time.deltaTime;
        }
   
        transform.position += velocity_vec * Time.deltaTime;
    }
}
