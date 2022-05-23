using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaScript : MonoBehaviour {
    public float movementSpeed;
    public float limitxPositive;
    public bool toRight;
    public float limitxNegative;

	// Use this for initialization
	void Start () {
        toRight = true;
	}
	
	// Update is called once per frame
	void Update () {
        if(toRight==true)
        {
            transform.position += new Vector3(movementSpeed, 0, 0);

        }
        else
        {
            transform.position -= new Vector3(movementSpeed, 0, 0);
        }

        if (transform.position.x > limitxPositive)
        {
            toRight = false;
        }
        else if(transform.position.x<limitxNegative)
        {
            toRight = true;
        }
	}
}
