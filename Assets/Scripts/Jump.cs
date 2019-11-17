using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jump_force;
    public Rigidbody rb;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Jumping!");
            rb.AddForce(0, jump_force, 0, ForceMode.VelocityChange);
            Debug.Log(other.name);

        }
        else
        {
            Debug.Log("else");
        }
    }

}
