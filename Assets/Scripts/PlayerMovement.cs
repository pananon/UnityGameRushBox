using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;
    public float FarwardForce = 1500f;
    public float SideForce = 500f;
    public float Accel = 1000f;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, FarwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(SideForce * Time.deltaTime , 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, Accel * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -Accel * Time.deltaTime);
        }
    }
}
