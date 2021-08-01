using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float carSpeed;

    public Rigidbody2D rd;

    private void Awake()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //start game
        //GameManager.IsGameRunning = true;

        
    }

    // Update is called once per frame
    void Update()
    {
        //rd.AddForce(Vector2.right);
    }


}
