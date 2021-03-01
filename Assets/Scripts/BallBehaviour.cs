using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {

public SpriteRenderer myRenderer;
public Color floorColour;
public Color gateColour;
public Color yellowColour;
public Color blueColour;
public Color hinge2Colour;
public Color gateColour2;
public Color greenColour;
public Color purpleColour;
public Rigidbody2D myBody;

public GameObject firstCam;

//private firstCam CameraFollow;


public float power;


    // Start is called before the first frame update
    void Start()
    {
        myRenderer = gameObject.GetComponent<SpriteRenderer>();
        myBody = gameObject.GetComponent<Rigidbody2D>();
        //CameraFollow = gameObject.GetComponent<firstCam>();
 
    }

    // Update is called once per frame
    void Update()
    {
        //returns true once
        if (Input.GetKeyDown(KeyCode.Space)) {
            myBody.AddForce(new Vector3(1, 0, 0) * power);
            
        }
    }

    void OnCollisionEnter2D(Collision2D other) {

        if (other.gameObject.name == "floor") {
            myRenderer.color = floorColour;
            Debug.Log("Hit floor");

        }
        
        if (other.gameObject.name == "cube 1") {

            myRenderer.color = greenColour;

            //CameraFollow.followTransform = "circle (1)";
            //firstCam.setActive = false;
           // secondCam.setActive = true;
        }

        if (other.gameObject.name == "floor (16)") {
            
            myRenderer.color = purpleColour;

        }
       
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name == "gate") {
            myRenderer.color = gateColour; 
            Debug.Log("passed through gate");

        }

        if (other.gameObject.name == "bluegate") {
            myRenderer.color = blueColour;


    }

    if (other.gameObject.name == "yellowgate") {
            myRenderer.color = yellowColour;
    }

    if (other.gameObject.name == "hinge (3)") {

        myRenderer.color = hinge2Colour;
    }

    if (other.gameObject.name == "redgate") {

        myRenderer.color = gateColour2;
    }
    }
    }
    


