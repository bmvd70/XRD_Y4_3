using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockChest : MonoBehaviour
{
    public HingeJoint joint;
    public int count1, count2, count3 ;
    public void Unlock() {
        
        Debug.Log("entered");
            joint.limits = new JointLimits {
                bounceMinVelocity = joint.limits.bounceMinVelocity,
                bounciness = joint.limits.bounciness,
                contactDistance = joint.limits.contactDistance,
                min = 0,
                max = 160
            };
            joint.spring = new JointSpring() { spring = 5, targetPosition = 160 };
        
       
    }

    public void increaseCount1()
    {
        count1++;
      ButtonsClicked();
        Debug.Log("count1 " + count1);
    }
    public void increaseCount2()
    {
        count2++;
        ButtonsClicked();

        Debug.Log("count2 " + count2);
    }
    public void increaseCount3()
    {
        count3++;
        ButtonsClicked();

        Debug.Log("count3 " + count3);
    }

    public void ButtonsClicked()
    {
        if (count1 >= 1 && count2 >= 1 && count3 >= 1)
        {
            Unlock();
            Debug.Log("All buttons clicked " );

        }

    }
    public void Lock() {
        joint.limits = new JointLimits {
            bounceMinVelocity = joint.limits.bounceMinVelocity,
            bounciness = joint.limits.bounciness,
            contactDistance = joint.limits.contactDistance,
            min = -2,
            max = 2
        };
    }
}
