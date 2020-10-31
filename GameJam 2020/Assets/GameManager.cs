using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public GameObject deathScreenUI;


    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            deathScreenUI.SetActive(true);
        }

    }

}
