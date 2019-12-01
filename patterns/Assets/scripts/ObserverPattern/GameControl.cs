using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public GameObject SpereObj;

    public GameObject Box1Obj;


    Subject subject = new Subject();


    // Start is called before the first frame update
    void Start()
    {
        Box b1 = new Box(Box1Obj, new Jump());

        subject.AddObserver(b1);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log((SpereObj.transform.position).x);

        if ((SpereObj.transform.position).x < 0.5f) 
        {
          
            subject.Notify();
        }
    }
}
