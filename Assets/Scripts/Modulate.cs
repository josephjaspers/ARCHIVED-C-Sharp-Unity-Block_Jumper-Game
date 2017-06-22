using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modulate : MonoBehaviour {

    private Vector3 startPos; //INITIAL POSITION
    private Quaternion startRot;

    string coordinate; //must equal X Y or Z

    public bool increasing = true;
    public float modulate_rate = 1;

    public float lower_bound = -3;
    public float upper_bound = 3;

    private float curr_pos;


    // Use this for initialization
    void Start()
    {
        startPos = transform.position;
        startRot = transform.rotation;
    }


    // Update is called once per frame
    void Update () {

	}
}
