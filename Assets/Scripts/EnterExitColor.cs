using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterExitColor : MonoBehaviour {

    public Color enter_color;
    public Color exit_color;

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = enter_color;
    }
    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = exit_color;
    }
}
