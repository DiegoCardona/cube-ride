using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speedAddition = 10;
    public float forwardForce = 500f;
    public float sideWaysForce = 400f;

    private void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) {
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);   
        } 
        else if (Input.GetKey("a")) {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);   
        } 
        else if (Input.GetKey("w")) {
            forwardForce += speedAddition;   
        } 

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
