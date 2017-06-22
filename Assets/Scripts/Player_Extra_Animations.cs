using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Extra_Animations : MonoBehaviour {

    public Animator anim;
    public string[] animations;
    public string[] mappedKey;

    // Update is called once per frame
    void Update () {
		for (int i = 0; i < animations.Length; ++i)
        {
                if (Input.GetKeyDown(mappedKey[i]))
            {
                anim.Play(animations[i]);
                return;
            }
        }
	}
}
