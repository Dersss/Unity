using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovementController : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject rb;
    bool descend;
    Vector3 iniPos;
    Vector3 velocity;
    void Start()
    {
        rb = GameObject.Find("Pickup");
        descend = false;
        iniPos = rb.transform.position;
        velocity = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // InvokeRepeating("SetRandomPos",0,240);
        
        if (rb.transform.position.x < -3f || rb.transform.position.x > 3f) {
            velocity = (velocity * -1);
        }
        rb.transform.position += velocity * Time.deltaTime;
    }
    void SetRandomPos() {
        // Vector3 temp = new Vector3(rb.transform.position.x,rb.transform.position.y,Random.Range(0,0));
        // transform.position = temp;
        
        
    }
}
