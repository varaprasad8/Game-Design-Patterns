using System.Collections;
using System.Collections.Generic;
using UnityEngine;


   public abstract class BoxEvents
    { 
        public abstract float GetJumpForce();
    }


public class Jump : BoxEvents
{
    public override float GetJumpForce()
    {
        return 90f;
    }
    
}
