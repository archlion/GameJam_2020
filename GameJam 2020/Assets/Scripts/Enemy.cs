using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private EnemySpawner enemySpawner;

    public Animator animator;

    public int maxHealth = 100;

    int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {

        currentHealth -= damage;

        animator.SetTrigger("Hurt");

        if (currentHealth <= 0)
        {
            Die();
        }

    }


    public void Die()
    {
        Debug.Log("enemy died!");

        animator.SetBool("IsDead", true);

        GetComponent<Rigidbody2D>().simulated = false;

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;

        Destroy(gameObject, 5f);
        enemySpawner = FindObjectOfType<EnemySpawner>();
        enemySpawner.enemiesInRoom--;
        if(enemySpawner.spawnTime <= 0 && enemySpawner.enemiesInRoom <= 0)
        {
            enemySpawner.spawnerDone = true;
        }
           

    }

    public void SpawnSound()
    {
        FindObjectOfType<AudioManager>().Play("spawnbunny");           //play spawnbunny sound
    }

}
