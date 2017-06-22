using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    private Vector3 startPos;
    private Quaternion startRot;
    public string respawn_key = "f";
    public GameObject[] victory_Objects;
	// Use this for initialization
	void Start () {
        startPos = transform.position;
        startRot = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(respawn_key))
        {
            transform.position = startPos;
            transform.rotation = startRot;
        }
	}
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "death")
        {
            transform.position = startPos;
            transform.rotation = startRot;
        }
        else if (collider.tag == "checkpoint")
        {
            startPos = transform.position;
            startRot = transform.rotation;
            collider.gameObject.SetActive(false);
        } else if (collider.tag == "Victory")
        {
            startPos = transform.position;
            startRot = transform.rotation;
            collider.gameObject.SetActive(false);

            for (int i = 0; i < victory_Objects.Length; ++i)
            {
                victory_Objects[i].SetActive(true);
            }
        }
    }
}
