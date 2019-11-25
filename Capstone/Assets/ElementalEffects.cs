using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementalEffects : MonoBehaviour
{

    public float liftForce = 10;
    private Rigidbody2D rb;
    private string type;
    private float angle;
    public Transform p1;
    public Transform p2;
    private AreaEffector2D areaEffector;
    
       
    // Start is called before the first frame update
    void Start()
    {
        type = this.tag;
        areaEffector = gameObject.GetComponent<AreaEffector2D>();
        angle = Mathf.Atan2(p2.position.y - p1.position.y, p2.position.x - p1.position.x) * 180 / Mathf.PI;
        areaEffector.forceAngle = angle;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void OnTriggerStay2D(Collider2D other)
    {

        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        var player = other.gameObject.GetComponent<PlayerMovement>();

        if (other.tag == "Player" && player.isGliding && type == "Lift")
        {
            Debug.Log("Trigger Occured");
            rb.velocity = Vector2.up * liftForce;
        }

    }
}
