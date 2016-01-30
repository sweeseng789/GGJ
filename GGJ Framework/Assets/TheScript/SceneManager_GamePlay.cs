using UnityEngine;
using System.Collections.Generic;

public class SceneManager_GamePlay : MonoBehaviour
{
    public GameObject Sweets;

	// Use this for initialization
	void Start ()
    {
        for(int a = 0; a < 4; ++a)
        {
            Vector3 newPos = new Vector3();
            newPos.x = Random.Range(-271, 271);
            newPos.z = Random.Range(-339, 186);
            newPos.y = Random.Range(277, 300);

            GameObject newSweet = Instantiate(Sweets) as GameObject;
            newSweet.transform.localPosition = newPos;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    Vector3 newPos = new Vector3();
        //    newPos.x = Random.Range(-271, 271);
        //    newPos.z = Random.Range(-339, 186);
        //    newPos.y = 277;

        //    GameObject newSweet = Instantiate(Sweets) as GameObject;
        //    newSweet.transform.localPosition = newPos;
        //    newSweet.GetComponent<Renderer>().enabled = false;

        //    sweetList.Add(newSweet);
        //}

        //if(Input.GetKeyDown(KeyCode.D))
        //{
        //    for(int a = 0; a < sweetList.Count; ++a)
        //    {
        //        sweetList[a].GetComponent<Renderer>().enabled = true;
        //    }
        //}

        //Debug.Log(getActiveFromList(sweetList));

        //if(Input.GetKeyDown(KeyCode.D))
        //{
        //    for(int a = 0; a < sweetList.Count; ++a)
        //    {
        //        if(sweetList[a].GetComponent<Renderer>().enabled == false)
        //        {
        //            sweetList[a].GetComponent<Renderer>().enabled = true;
        //        }
        //    }
        //}
        if(GameObject.FindObjectsOfType<Sweet>().Length < 4)
        {
            Vector3 newPos = new Vector3();
            newPos.x = Random.Range(-271, 271);
            newPos.z = Random.Range(-339, 186);
            newPos.y = 277;

            GameObject newSweet = Instantiate(Sweets) as GameObject;
            newSweet.transform.localPosition = newPos;
        }

        //Debug.Log(sweetCount);
    }
}
