using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flippers : MonoBehaviour
{
    public HingeJoint2D left;
    public HingeJoint2D right;
    public float power = 100.0f;

    private void Update()
    {
        JointMotor2D leftMotor = left.motor;
        JointMotor2D rightMotor = right.motor;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            leftMotor.motorSpeed = -power;
        }
        else
        {
            leftMotor.motorSpeed = power;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rightMotor.motorSpeed = power;
        }
        else
        {
            rightMotor.motorSpeed = -power;
        }

        left.motor = leftMotor;
        right.motor = rightMotor;
    }
}
