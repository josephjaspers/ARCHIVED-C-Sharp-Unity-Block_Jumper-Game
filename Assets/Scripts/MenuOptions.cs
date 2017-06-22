using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuOptions : MonoBehaviour {

    public GameObject controlsText;
	// Use this for initialization
	void Start () {
        controlsText.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        } else if (Input.GetKeyDown(KeyCode.Return))
        {
            Application.LoadLevel(1);
        } else if (Input.GetKeyDown("c"))
        {
            if (controlsText.activeInHierarchy)
            {
                controlsText.SetActive(false);
            } else
            {
                controlsText.SetActive(true);
            }
        }
	}
}
