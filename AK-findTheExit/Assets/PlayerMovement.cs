using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform just holds info about obj
        //calling translate actually moves the obj
        //transform and translate go hand to hand


        //---------------------------------------------------------
        // getAxisRaw - values are consatly being parsed
        // getAxis - values only parsed when key is pressed down
        //---------------------------------------------------------
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //creates a random arrow illustrating where the obj is going to 
        // move, based on the inputs of the horizontal keys(a,d or left/right arrow)
        // and based on verticle keys(w,s and up/down arrow)
        // y left as 0 because that would demostrate jumping/falling
        Vector3 destination = new Vector3(horizontal, 0, vertical);
        //Debug.Log(destination);


        // ------------------------------------------------------------------
        // will move obj, based on destination ( vector made based on 
        // player inputs) then multiples by the speed we want the obj to
        // to move at. Then Time.deltaTime so it moves smoothly
        // ------------------------------------------------------------------
        //                                              V multiplied by timeDelta so action is done smoothly among multiple frames.
        transform.Translate(destination * speed * Time.deltaTime);
    }
}
