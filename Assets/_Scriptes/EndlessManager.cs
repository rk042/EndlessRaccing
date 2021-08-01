using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class EndlessManager : MonoBehaviour
{

    public SpriteShapeController ground;
    public float offset;
    public List<GameObject> _treesList = new List<GameObject>(); 
    
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

            Instantiate(_treesList[Random.Range(0, _treesList.Count)],new Vector2(ground.spline.GetPosition(i).x, ground.spline.GetPosition(i).y),Quaternion.identity);
        }

        //for (int i = 2; i < 500; i++)
        //{
        //    ground.spline.SetTangentMode(i, ShapeTangentMode.Continuous);
        //    ground.spline.SetLeftTangent(i, new Vector3(-1, 0, 0));
        //    ground.spline.SetRightTangent(i, new Vector3(1, 0, 0));
                
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
