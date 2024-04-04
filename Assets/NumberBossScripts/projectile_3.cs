using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile_3 : MonoBehaviour
{
    public float velocity_mag_circle = 1;
    public float period = 1;

    private Vector3 velocity_vec_circle; // if it can hit the player
    private Vector3 velocity_vec_circle_sideways; // if it can hit the player
    private float start_time = 0;

    // Start is called before the first frame update
    void Start()
    {
        start_time = Time.time;

        velocity_vec_circle = transform.up; // quaterions are just magic trust
        velocity_vec_circle *= velocity_mag_circle;

        velocity_vec_circle_sideways = transform.right; // quaterions are just magic trust
        velocity_vec_circle_sideways *= velocity_mag_circle;
    }

    // Update is called once per frame
    void Update()
    {
        float delta_time = (Time.time - start_time);
        float angle = (2 * Mathf.PI * delta_time / period) % Mathf.PI;

        transform.position += velocity_vec_circle          * Time.deltaTime * Mathf.Cos(angle) * (3 * delta_time) /(delta_time + 1);
        transform.position += velocity_vec_circle_sideways * Time.deltaTime * Mathf.Sin(angle);
    }
}
