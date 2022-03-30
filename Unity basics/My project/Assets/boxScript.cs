using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour
{
    Vector3 goUp, goDown, goLeft, goRight, goJump;
    public float speed = 2.0f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start() //like a constructor
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        goUp = new Vector3(0f, 0f, 1f);
        goDown = new Vector3(0f, 0f, -1f);
        goLeft = new Vector3(-1f, 0f, 0f);
        goRight = new Vector3(1f, 0f, 0f);
        goJump = new Vector3(0f, 2f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        //this is the game object that this script is attached to
        
        // use += rather than = to create a smoother movement curve? use this in the future.
        if (Input.GetKeyDown("up"))
        {
            print("up key was pressed");
            rb.velocity = goUp * speed;
        }
        else if (Input.GetKeyDown("down"))
        {
            print("down key was pressed");
            rb.velocity = goDown * speed;
        }
        else if (Input.GetKeyDown("left"))
        {
            print("left key was pressed");
            rb.velocity = Vector3.left * speed;
        }
        else if (Input.GetKeyDown("right"))
        {
            print("right key was pressed");
            rb.velocity = goRight * speed;
        }
        else if (Input.GetKeyDown("space"))
        {
            print("space bar was pressed");
            rb.velocity = goJump * speed;
        }
    }
    //cabbage
}


