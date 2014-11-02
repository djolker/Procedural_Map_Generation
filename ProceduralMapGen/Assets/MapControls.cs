using UnityEngine;
using System.Collections;

public class MapControls : MonoBehaviour {

	public GameObject Hall;

	public Vector3 lastPiece;

	// Use this for initialization
	void Start () {
		Debug.Log (GameObject.Find ("Start").collider.bounds.size);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			addHall();
		}
	}

	void addHall()
	{
		if (lastPiece == null) 
        {
            lastPiece = GameObject.Find("Start").transform.position;
            int x = 0;
		}

        Vector3 newPos = lastPiece;

        newPos.z += 10;
        Hall.transform.Translate(newPos);



        Instantiate(Hall, newPos, Hall.transform.rotation);

        lastPiece = newPos;
	}
}
