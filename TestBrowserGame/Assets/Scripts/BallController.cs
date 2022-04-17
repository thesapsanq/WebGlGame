using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BallController : MonoBehaviour
{
    public Rigidbody rigidBodyBall;


    public static DateTime startTime;

    private void Start()
    {
        startTime = DateTime.Now;
    }
    private float force = 10.0f;
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            rigidBodyBall.AddForce(Vector3.forward * force, ForceMode.Force);
        if (Input.GetKey(KeyCode.S))
            rigidBodyBall.AddForce(Vector3.forward * -force, ForceMode.Force);
        if (Input.GetKey(KeyCode.D))
            rigidBodyBall.AddForce(Vector3.right * force, ForceMode.Force);
        if (Input.GetKey(KeyCode.A))
            rigidBodyBall.AddForce(Vector3.right * -force, ForceMode.Force);
        if (Input.GetKey(KeyCode.Escape))
            SceneManager.LoadScene("MainMenu");

    }
}
