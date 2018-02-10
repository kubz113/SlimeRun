﻿using UnityEngine;
using System.Collections;

public class Touch : MonoBehaviour {
    private controls player;

    // Use this for initialization
    void Start () {
        player = FindObjectOfType<controls>();
    }

    public void LeftArrow()
    {
        player.moveright = false;
        player.moveleft = true;
    }
    public void RightArrow()
    {
        player.moveright = true;
        player.moveleft = false;
    }
    public void ReleaseLeftArrow()
    {
        player.moveleft = false;
    }
    public void ReleaseRightArrow()
    {
        player.moveright = false;

    }

    // Update is called once per frame
    void Update () {
	
	}
}
