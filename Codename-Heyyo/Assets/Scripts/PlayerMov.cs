using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMov : MonoBehaviour
{
    public float moveSpeed;
    public float maxSpeeed;
    private Vector3 input;
    private Vector3 spawn;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        if (GetComponent<Rigidbody>().velocity.magnitude < maxSpeeed)
        {

            GetComponent<Rigidbody>().AddForce(input * moveSpeed);

        }
        else 
        {
            GetComponent<Rigidbody>().AddForce(input / moveSpeed);

        }

    }
}
