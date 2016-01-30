using UnityEngine;
using System.Collections;

public class Sweet : MonoBehaviour {

    //// Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}

    Vector3 vel = new Vector3();
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(transform.localPosition.y < -10)
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        //vel += Physics.gravity;
        //rb.AddForce(vel, ForceMode.Acceleration);
    }

    void OnCollisionEnter(Collision col)
    {
        vel.Set(0, 0, 0);
    }

    void OnCollisionExit(Collision col)
    {
        vel.Set(0, 0, 0);
    }
}
