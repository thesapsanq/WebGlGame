using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform ball;
    private Vector3 deltaPos;

    // Start is called before the first frame update
    void Start()
    {
        deltaPos = transform.position - ball.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.position + deltaPos;
    }
}
