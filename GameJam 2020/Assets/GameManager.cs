using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public GameObject deathScreenUI;
    public GameObject winScreenUI;
    public GameObject player;
    public GameObject arena;

    void Update()
    {
        if (gameHasEnded == true)
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");

            foreach (GameObject enemy in enemies)
            {
                GameObject.Destroy(enemy);
            }
        }
    }


    public void LoseGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER!");
            deathScreenUI.SetActive(true);
        }

    }

    public void WinGame()
    {
        if (gameHasEnded == false)
        {
            Debug.Log("YOU WIN!");
            arena.SetActive(false);

            GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");

                foreach (GameObject enemy in enemies)
                {
                    GameObject.Destroy(enemy);
                }

            gameHasEnded = true;
            winScreenUI.SetActive(true);
            player.SetActive(false);

        }

    }
    public void CleanUp()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");

        foreach (GameObject enemy in enemies)
        {
            GameObject.Destroy(enemy);
        }
    }
}


