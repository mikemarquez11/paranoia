using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider objecto)
    {
        if (objecto.gameObject.tag == "Estrella")
        {
            Destroy(objecto.gameObject);
            GameManager.stars++;
        }
    }
}
