using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject01 : MonoBehaviour
{
    [SerializeField] Vector3 moveDirection;
    Vector3 myVector;
    // Start is called before the first frame update
    void Start()
    {
        myVector = new Vector3(10.0f,0.0f,0.0f); //added a direction with magnitude
    }
    

    // Update is called once per frame
    void Update()
    {
        // My position equals my position PLUS 
	    // where I want to be by the end of this frame...
        
        transform.position = transform.position + myVector;
    }
}
