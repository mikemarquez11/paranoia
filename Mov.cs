using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour {
	public float velocidad = 1f;
	public Vector3 direccion = Vector3.zero;
	public float salto = 2f;
	public float gravedad = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CharacterController control = gameObject.GetComponent<CharacterController> ();
		if (control.isGrounded) {
			// me muevo sobre el eje x
			direccion = new Vector3 (0, 0, Input.GetAxis ("Horizontal"));
			//cambio direccion
			direccion = transform.TransformDirection (direccion);
			// me muevo basado en la velocidad
			direccion = direccion * velocidad;
			// detectar si presiona saltar
			if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.UpArrow)) {
				direccion.y = salto;
			}
		}
		direccion.y = direccion.y - (gravedad * Time.deltaTime);
		control.Move (direccion);

	}
}
