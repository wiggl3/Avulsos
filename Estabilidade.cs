using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estabilidade : MonoBehaviour {

	[SerializeField]WheelCollider rodaTrazEsq, rodaTrazDir;
	[SerializeField]float forca = 10000, estability = 800;
	private Rigidbody RB;
	private bool estaNoChao1, estaNoChao2;

	// Use this for initialization
	void Start () {
		RB = GetComponent<Rigidbody> ();
		RB.centerOfMass += new Vector3 (0, -0.3f, -0.3f);
	}
	
	// Update is called once per frame
	void Update () {
		float forcaEsqTraz = 1;
		float forcaDirTraz = 1;

		WheelHit hit;
		estaNoChao1 = rodaTrazEsq.GetGroundHit (out hit);
		if (estaNoChao1) 
		{
			forcaEsqTraz = (-rodaTrazEsq.transform.InverseTransformPoint (hit.point).y - rodaTrazEsq.radius) / rodaTrazEsq.suspensionDistance;
		}

		estaNoChao2 = rodaTrazDir.GetGroundHit (out hit);
		if (estaNoChao2) 
		{
			forcaDirTraz = (-rodaTrazDir.transform.InverseTransformPoint (hit.point).y - rodaTrazDir.radius) / rodaTrazDir.suspensionDistance;
		}

		float antiRolForce = (forcaEsqTraz - forcaDirTraz) * forca;

		if (estaNoChao1) 
		{
			RB.AddForceAtPosition (rodaTrazEsq.transform.up * -antiRolForce, rodaTrazEsq.transform.position);
		}

		if (estaNoChao2) 
		{
			RB.AddForceAtPosition (rodaTrazDir.transform.up * -antiRolForce, rodaTrazDir.transform.position);
		}
	}

	void FixedUpdate()
	{
		if (estaNoChao1 || estaNoChao2) 
		{
			RB.AddForce (-transform.up * (5000 + estability * Mathf.Abs ((RB.velocity.magnitude * 3.6f))));
		}

		RB.velocity = Vector3.ClampMagnitude (RB.velocity, 300);
	}
}
