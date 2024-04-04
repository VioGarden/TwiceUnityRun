using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHellBoss : MonoBehaviour
{
    private float timer = 0;

    private Vector3 start_pos;

    public int health = 1;

    public float move_radius = 1;
    public float move_period = 1;
    private Vector3 leap_1;
    private Vector3 leap_2;

    private int current_attack = 1;

    public int spawn_radius = 1;

    public GameObject projectile_1 = null;
    public GameObject projectile_2 = null;
    public GameObject projectile_3 = null;
    public GameObject projectile_4 = null;
    public GameObject projectile_5 = null;
    public GameObject projectile_6 = null;
    public GameObject projectile_7 = null;
    public GameObject projectile_8 = null;

    private float attack_timer = 0f; 
    private float attack_change_timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        start_pos = transform.position;

        leap_1 = start_pos;
        leap_2 = move_radius * Random.Range(-1f, 1f) * transform.up + move_radius * Random.Range(-1f, 1f) * transform.right + start_pos;
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        Attack();

        if (health <= 0)
        {
            Kill();
        }
    }

    private void Move()
    {
        timer += Time.deltaTime;

        if (timer >= move_period)
        {
            timer = 0;
            leap_1 = leap_2;
            leap_2 = move_radius * Random.Range(-1f, 1f) * transform.up + move_radius * Random.Range(-1f, 1f) * transform.right + start_pos;
        }


        float percent = timer / move_period;

        transform.position = (1 - percent) * leap_1 + percent * leap_2;
    }

    void Kill() {
        Destroy(gameObject);
    }

    GameObject[] InstantiateRing(int radius, int number, GameObject tpye, float rotation_offset) {
        GameObject[] objects = new GameObject[number];

        float delta_angle = (2 * Mathf.PI)/number;

        for (int i = 0; i < number; i++) {
            float angle = delta_angle * i + rotation_offset; 

            float cos = Mathf.Cos(angle);
            float sin = Mathf.Sin(angle);

            Vector3 spawnPosition = new Vector3(cos * radius, sin * radius, 0) + transform.position;
            Quaternion rotation = Quaternion.Euler(0, 0, angle * Mathf.Rad2Deg - Mathf.PI/2 * Mathf.Rad2Deg); // Convert radians to degrees for rotation

            Instantiate(tpye, spawnPosition, rotation); // "new Quaternion(0,0,sin, cos)" just thus, the magic
        }

        return objects;
    }

    void Attack()
    {
        GameObject[] projectiles = { projectile_1, projectile_2, projectile_3, projectile_4, projectile_5, projectile_6, projectile_7, projectile_8 };
        int[] num_of_bullets = { 30,20,20,20,20,20,20,20 };
        float[] attack_change_timers = new float[] { 5, 5, 5, 5, 5, 5, 5, 5 };
        float[] attack_timers = { 0.5f, 1.5f, 5f, 1.5f, 2f, 2f, 2f, 0.75f };
        int[] health_costs = { 2,2,2,2,2,2,2,2 };


        attack_timer -= Time.deltaTime;
        attack_change_timer -= Time.deltaTime;

        if (attack_timer >= 0) { return; }
        if (attack_change_timer < 0)
        {
            int temp = current_attack;
            do
            {
                current_attack = Random.Range(1, 9);
            } while (projectiles[current_attack - 1] == null || temp == current_attack);

            attack_change_timer = attack_change_timers[current_attack - 1];

        }


        GameObject[] projectiles_launched;


        float rotation_offset = Time.time *3;

        attack_timer = attack_timers[current_attack - 1];
        projectiles_launched = InstantiateRing(spawn_radius, num_of_bullets[current_attack - 1], projectiles[current_attack - 1], rotation_offset);
        health -= health_costs[current_attack - 1];

    }

} 
