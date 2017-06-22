using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public float rotate_x = 10;
    public float rotate_y = 0;
    public float rotate_z = 0; 
	

	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(rotate_x, rotate_y, rotate_z) * Time.deltaTime);
	}
}
