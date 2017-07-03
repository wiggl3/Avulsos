using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class Veiculo : MonoBehaviour {

	[SerializeField] Transform[] MeshRodas;
	[SerializeField]WheelCollider [] ColisorRodas;
	[SerializeField]float torque = 1000, pesoVeiculo = 1500;
	private float angulo, direcao;
	private Rigidbody RB;

	// Use this for initialization
	void Start () {
		RB = GetComponent<Rigidbody> ();
		RB.mass = pesoVeiculo;
	}
	
	// Update is called once per frame
	void Update () {
		direcao = Input.GetAxis ("Horizontal"); //input para ele mover para os lados. diracao é a variavel criada

		if (Input.GetAxis ("Horizontal") > 0.3f || Input.GetAxis ("Horizontal") < -0.3f) //se o botao estiver pressionado, ele movimenta em 0.4 segundos
		{
			angulo = Mathf.Lerp (angulo, direcao, Time.deltaTime * 4);
		}

		else 
		{
			angulo = Mathf.Lerp (angulo, direcao, Time.deltaTime * 2); //se não estiver pressinado ele para em 0.2 segundos
		}

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			ColisorRodas [2].brakeTorque = Input.GetAxis ("Vertical") * 0;
			ColisorRodas [3].brakeTorque = Input.GetAxis ("Vertical") * 0;
		}

		if (Input.GetKey (KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) 
		{
			torque += 100;
		}

		if (torque >= 55000) 
		{
			torque = 55000;
		}
	}

	void FixedUpdate()
	{
		ColisorRodas [0].steerAngle = angulo * 40;//mandando as rodas dianteiras movimentarem em até 40 graus
		ColisorRodas [1].steerAngle = angulo * 40;
		//
		ColisorRodas [2].motorTorque = Input.GetAxis ("Vertical") * torque;//mandando as rodas traseiras imprementarem força para andar 
		ColisorRodas [3].motorTorque = Input.GetAxis ("Vertical") * torque;

		for (int x = 0; x < ColisorRodas.Length; x++) //verifica roda por roda para mandar o objeto movimentar junto com o colisor
		{
			Quaternion quat;//quaternion para rotação
			Vector3 pos;//vetor para posição
			ColisorRodas [x].GetWorldPose (out pos, out quat);//pegando a posiçao no mundo
			MeshRodas [x].position = pos;//passando a posição e a rotação para o objeto
			MeshRodas [x].rotation = quat;
		}
	}
}
