using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Extra_Movement_Animations : MonoBehaviour
{

    public Animator anim;
    public string[] animations;
    public string[] mappedKey;
    public string[] Animator_bools_setter;
    public string[] Animator_bools_getter;
    public bool[] Animator_bools_getter_comparison; 
    public float[] min_movement;
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < animations.Length; ++i)
        {
            anim.SetBool(Animator_bools_setter[i], false);
            if (Input.GetKey(mappedKey[i]) && (Input.GetAxis("Vertical") > min_movement[i]  || Input.GetAxis("Horizontal") > min_movement[i])
                && anim.GetBool(Animator_bools_getter[i]) == Animator_bools_getter_comparison[i])
            {
                anim.Play(animations[i]);
                anim.SetBool(Animator_bools_setter[i], true);
                return;
            }
        }
    }
}
 