using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequentialBlocks : MonoBehaviour {

    public GameObject[] blocks;
    public GameObject[] checkPoints;
    int curr_active;
	// Use this for initialization
	void Start () {
        //blocks = GetComponent<GameObject[]>();
        //checkPoints = GetComponent<GameObject[]>();

        for (int i = 1; i < blocks.Length; ++i)
        {
            if (blocks[i] != null)
            blocks[i].SetActive(false);

            if (checkPoints[i] != null)
            {
                checkPoints[i].SetActive(false);
            }
        }

        if (blocks[0] != null)
        blocks[0].SetActive(true);
	}
    // Update is called once per frame
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Jumping_Block"))
        {
            if (collision.gameObject.Equals(blocks[curr_active]))
            {   
                if (curr_active  + 1 < blocks.Length)
                {
                    blocks[curr_active + 1].SetActive(true);
                    if(checkPoints[curr_active + 1] != null)
                    {
                        checkPoints[curr_active + 1].SetActive(true);
                    }
                    ++curr_active;
                }
            }
        }
    }
}
