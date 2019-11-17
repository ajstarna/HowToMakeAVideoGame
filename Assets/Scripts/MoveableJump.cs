
using UnityEngine;

public class MoveableJump : Jump
{
    public float sideways_velocity;
    void FixedUpdate()
    {

        if (Input.GetKey("right"))
        {
            transform.position += Vector3.right * Time.deltaTime * sideways_velocity;
            //rb.AddForce(sideways_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("left"))
        {
            transform.position += Vector3.left * Time.deltaTime * sideways_velocity;
            //rb.AddForce(-sideways_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}
