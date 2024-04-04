using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_1 : MonoBehaviour
{
    public float velocity_mag = 1;
    private Vector3 velocity_vec; // if it can hit the player

    // Start is called before the first frame update
    void Start()
    {
        velocity_vec = transform.up; // quaterions are just magic trust
        velocity_vec *= velocity_mag;
    }

    // Update is called once per fram
    void Update()
    {
        transform.position += velocity_vec * Time.deltaTime;
    }
}
