using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeUpWin : MonoBehaviour
{
    public void TimeUp()
    {
        FindObjectOfType<GameManager>().WinGame();
    }

    public void PreCleanUp()
    {
        FindObjectOfType<GameManager>().CleanUp();
    }
}
