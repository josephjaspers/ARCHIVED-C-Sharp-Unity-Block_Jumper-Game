using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable_MouseOrbit : MonoBehaviour {

    public GameObject focused_object;
    public string mapped_key;
    public bool auto_align;

    Vector3 forward_offset;
    Vector3 relative_position;

    private void Start()
    {
        forward_offset = focused_object.transform.forward - transform.forward;
        //Get relative coordinates 
        relative_position = focused_object.transform.InverseTransformPoint(transform.position);
    }

    // Update is called once per frame
    void Update() {

		if (Input.GetKeyDown(mapped_key))
        {
            if (GetComponent<MouseOrbitImproved>().enabled)
            {
                GetComponent<MouseOrbitImproved>().enabled = false;
                if (auto_align)
                    align();
            }
            else
            {
                GetComponent<MouseOrbitImproved>().enabled = true;
            }
        }
        //Thought this would fix but gives a super weird thing outcome
        //if (!(GetComponent<MouseOrbitImproved>().enabled))
        //    align();


    }
    void align()
    {
        transform.forward = focused_object.transform.forward - forward_offset;
        transform.position = focused_object.transform.TransformPoint(relative_position);
        // transform.position.Set(transform.position.x, transform.position.y , transform.position.z);

    }
}
