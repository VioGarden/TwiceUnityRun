using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemStats : MonoBehaviour
{
    [SerializeField] public int golemHealth;
    [SerializeField] public int golemMaxHealth;
    [SerializeField] public int golemAttackDamage;
    [SerializeField] public int golemLodgeDamage;
    [SerializeField] public int golemSpeed;

    [SerializeField] floatingHealthBar healthBar;

    public PlayerStats stats;

    public Renderer golemRenderer;

    // When damaged, flash red
    public Color damageColorGolem = new Color(0.945f, 0.298f, 0.016f);
    public float damageDuration = 0.1f;
    private Color originalColor;

    public int golemVariant;

    private void Awake()
    {
        healthBar = GetComponentInChildren<floatingHealthBar>();
    }

    void Start()
    {
        if (golemVariant == 1)
        {
            InitVariablesGolem();
        }
        else
        {
            InitVariablesGolem();
        }
        originalColor = golemRenderer.material.color;
    }


    public void DamageGolem(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("No negative damage");
        }
        this.golemHealth -= amount;
        healthBar.UpdateHealthBar(golemHealth, golemMaxHealth);
        if (golemHealth <= 0)
        {
            ChooseBuffGolem();
            Die();
        }
        else
        {
            StartCoroutine(FlashColor());
        }
    }

    private IEnumerator FlashColor()
    {
        // Change the color to damage color
        golemRenderer.material.color = damageColorGolem;

        // Wait for a short duration
        yield return new WaitForSeconds(damageDuration);

        // Revert back to the original color
        golemRenderer.material.color = originalColor;
    }


    // When monster dies, player gets some buff
    public void ChooseBuffGolem()
    {
        int randomNumber = Random.Range(1, 6);

        // Execute the corresponding function based on the selected number
        switch (randomNumber)
        {
            case 1:
                IncreaseADRandomGolem();
                break;
            case 2:
                IncreaseHealthRandomGolem();
                break;
            case 3:
                IncreaseSpeedRandomGolem();
                break;
            case 4:
                IncreaseKnockBackRandomGolem();
                break;
            case 5:
                IncreaseCamoRandomGolem();
                break;
        }

    }

    private void IncreaseADRandomGolem()
    {
        int randomAD = Random.Range(50, 50);
        stats.IncreaseAD(randomAD);
    }

    private void IncreaseHealthRandomGolem()
    {
        int randomHealth = Random.Range(600, 600);
        stats.Heal(randomHealth);
    }

    private void IncreaseSpeedRandomGolem()
    {
        int randomSpeed = Random.Range(30, 30);
        stats.IncreaseSpeed(randomSpeed);
    }

    private void IncreaseKnockBackRandomGolem()
    {
        float randomKO = Random.Range(40f, 40f);
        stats.IncreaseKnockBack(randomKO);
    }

    private void IncreaseCamoRandomGolem()
    {
        float randomCamo = Random.Range(20f, 20f);
        stats.IncreaseCamo(randomCamo);
    }

    public void InitVariablesGolem()
    {
        this.golemHealth = 1000;
        this.golemMaxHealth = 1000;
        int randomAttackDamageGolem = Random.Range(5, 40);
        this.golemAttackDamage = randomAttackDamageGolem;
        int randomLodgeDamageGolem = Random.Range(10, 15);
        this.golemLodgeDamage = randomLodgeDamageGolem;
        int randomSpeedGolem = Random.Range(5, 20);
        this.golemSpeed = randomSpeedGolem;
        healthBar.UpdateHealthBar(1000, 1000);
    }

    //public void InitVariablesGolem2()
    //{
    //    this.golemHealth = 1000;
    //    this.golemMaxHealth = 1000;
    //    int randomAttackDamageGolem = Random.Range(5, 40);
    //    this.golemAttackDamage = randomAttackDamageGolem;
    //    int randomLodgeDamageGolem = Random.Range(10, 50);
    //    this.golemLodgeDamage = randomLodgeDamageGolem;
    //    int randomSpeedGolem = Random.Range(20, 50);
    //    this.golemSpeed = randomSpeedGolem;
    //    healthBar.UpdateHealthBar(1000, 1000);
    //}

    private void Die()
    {
        Debug.Log("Golem Perished");
        StatsManager.Instance.monsterKillCount += 1;
        float randomMultIncrease = Random.Range(3f, 5f);
        StatsManager.Instance.globalMultiplier += randomMultIncrease;
        StatsManager.Instance.globalScore += (100f * StatsManager.Instance.globalMultiplier);
        Destroy(gameObject);
    }

}
