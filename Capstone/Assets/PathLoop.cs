using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathLoop : MonoBehaviour
{
    public Transform[] path;
    public float speed = 30.0f;
    public int waypoint = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (waypoint <= path.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, path[waypoint].transform.position, speed * Time.deltaTime);


            if (transform.position.Equals( path[waypoint].transform.position))
            {
                if (waypoint == path.Length -1)
                {
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
