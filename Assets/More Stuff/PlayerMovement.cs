using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour {
    public Transform head;
    //public Rigidbody rb;
    public CharacterController c;
    public int speed = 4;
    private bool moving = false;
    private int PlayerSC = 0;
    // Update is called once per frame
    void Update () {
        float forwardx = head.forward.x;
        float forwardz = head.forward.z;
        Vector3 forward = new Vector3(forwardx, 0, forwardz);
        forward.Normalize();
        if (Input.GetKey(KeyCode.Mouse0))
        {
            c.SimpleMove(forward*speed);
        } else if (!Input.GetKey(KeyCode.Mouse0))
        {
            c.SimpleMove(Vector3.zero);
        }
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Win")
        {
            Destroy(other.gameObject);
            PlayerSC++;
        }
    }
    public int getScore()
    {
        return PlayerSC;
    }
}
