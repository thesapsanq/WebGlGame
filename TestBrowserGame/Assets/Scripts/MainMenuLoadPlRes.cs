using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLoadPlRes : MonoBehaviour
{
    public void LoadGameSc()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadResultSc()
    {
        SceneManager.LoadScene("Results");
    }
}
