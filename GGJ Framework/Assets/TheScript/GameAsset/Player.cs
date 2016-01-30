using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public GameObject Object;
	public AudioClip Sound;

	private AudioSource enter16;

	// Use this for initialization
	void Start ()
    {
        Debug.Log("Everything is Awesome");
	}

	void Awake () {
		enter16 = GetComponent<AudioSource>();
	}


	
	// Update is called once per frame
	void Update ()
    {
        Vector3 newPos = transform.localPosition;

        if(Input.GetKey(KeyCode.W))
        {
            newPos.z += 50 * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            newPos.z -= 50 * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            newPos.x -= 50 * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            newPos.x += 50 * Time.deltaTime;
        }

        transform.localPosition = newPos;

        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse is down");

            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

            if(hit)
            {
                Debug.Log("hit " + hitInfo.transform.gameObject.name);
				enter16.PlayOneShot (Sound);
            }
            else
            {
                Debug.Log("So Close yet So Far");
            }
        }
    }
}
