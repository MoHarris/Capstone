using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public Transform[] path;
    public float speed = 30.0f;
    private int waypoint = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = path[waypoint].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(waypoint <= path.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, path[waypoint].transform.position, speed * Time.deltaTime);

           
            if(transform.position == path[waypoint].transform.position)
            {
                if(waypoint == path.Length - 1)
                {
                    transform.position = path[0].transform.position;
                    waypoint = 0;
                }

                else
                {
                    waypoint = waypoint + 1;
                }

            }
            

        }
        
    }
}
