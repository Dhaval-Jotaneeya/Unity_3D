using UnityEngine;

public class Player_mov : MonoBehaviour
{
    public Rigidbody rb;
    public int wforce;
    public int aforce;
    public int dforce;

    void FixedUpdate()
    {
        if(Input.GetKey("w"))
        {
            rb.AddForce(0, 0, wforce * Time.deltaTime,ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(dforce*Time.deltaTime, 0, wforce * Time.deltaTime, ForceMode.VelocityChange );
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(aforce * Time.deltaTime, 0, wforce * Time.deltaTime, ForceMode.VelocityChange );
        }
    }
}
