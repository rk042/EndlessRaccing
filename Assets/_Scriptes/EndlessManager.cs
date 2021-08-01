using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class EndlessManager : MonoBehaviour
{

    public SpriteShapeController ground;
    public float offset;
   
    
    // Start is called before the first frame update
    void Start()
    {

        //get component
        ground = GetComponent<SpriteShapeController>();

        //set position
        ground.spline.SetPosition(2, ground.spline.GetPosition(2) + Vector3.right * offset);
        ground.spline.SetPosition(3, ground.spline.GetPosition(3) + Vector3.right * offset);

        //add more mountan in road
        for (int i = 0; i < 500; i++)
        {
            float posx = ground.spline.GetPosition(i + 1).x + 10f;

            ground.spline.InsertPointAt(i + 2, new Vector3(posx, Random.Range(0, 2f)));
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
