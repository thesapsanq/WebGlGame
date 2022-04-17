using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFinishOrLose : MonoBehaviour
{
    public static int finish = 0;

    public static TimeSpan timer;

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Finish")
        {
            SceneManager.LoadScene("Results");
            finish = 1;
            timer = DateTime.Now - BallController.startTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Lose")
        {
            SceneManager.LoadScene("Results");
            finish = 2;
        }
    }

}
