using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    public float wheelRotationSpeed;
    public Rigidbody2D rd;



    private void Awake()
    {
        rd = GetComponent<Rigidbody2D>();

    }   
    // Update is called once per frame
    void Update()
    {
        if (GameManager.IsGameRunning)
        {
            rd.angularVelocity = wheelRotationSpeed * -100;
        }
    }   
}
