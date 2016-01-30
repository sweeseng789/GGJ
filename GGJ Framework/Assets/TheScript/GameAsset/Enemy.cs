using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    Sweet sweet;

	// Use this for initialization
	void Start ()
    {
        int a = 0;
        var objects = GameObject.FindObjectsOfType<Sweet>();
        //for(int b = 0; b < objects.Length)
        Debug.Log(objects.Length);
	}
	
	// Update is called once per frame
	void Update ()
    {
        //var objects = GameObject.FindObjectsOfType<Sweet>();
        ////for(int b = 0; b < objects.Length)
        //Debug.Log(objects.Length);
        if(sweet == null)
        {
            Debug.Log("Starting");
            for(int a = 0; a < GameObject.FindObjectsOfType<Sweet>().Length; ++a)
            {
                sweet = GameObject.FindObjectsOfType<Sweet>()[a];
            }
        }
        else
        {
            Vector3 diff = sweet.transform.position - transform.position;
            diff.Normalize();

            transform.position += diff * Time.deltaTime * 20.0f;
        }
    }
}
