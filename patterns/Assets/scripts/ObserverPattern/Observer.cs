﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer
{
    public abstract void onNotify();
}

public class Box : Observer
{
    GameObject boxObj;

    BoxEvents boxEvent;


    public Box(GameObject boxObj,BoxEvents boxEvent)
    {
        this.boxObj = boxObj;
        this.boxEvent = boxEvent;
    }

    public override void onNotify()
    {
        Jump(boxEvent.GetJumpForce());
    }

    void Jump(float jumpForce)
    {
        if (boxObj.transform.position.y < 0.55f)
        {
            Debug.Log("?");
            boxObj.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
        }
    }
}



