using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shot : MonoBehaviour {

	[SerializeField]GameObject gun;
	[SerializeField]GameObject [] shots;
	[SerializeField]int speed;
	[SerializeField]int element;
	[SerializeField]Text shotColor;
	public int q1, q2, q3, q4;
	[SerializeField]Text q1TXT, q2TXT, q3TXT, q4TXT;
	[SerializeField]GameObject menu;
	// Use this for initialization
	void Start () {
		element = 0;
		shotColor.text = shotColor.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		Shooting ();

		q1TXT.text = q1.ToString ();
		q2TXT.text = q2.ToString ();
		q3TXT.text = q3.ToString ();
		q4TXT.text = q4.ToString ();

		if (Input.GetKey (KeyCode.LeftControl)) {
			menu.SetActive (true);
		}

		else 
		{
			menu.SetActive (false);
		}

		if (element == 1) 
		{
			shotColor.text = "Green";
		}

		if (element == 2) 
		{
			shotColor.text = "Purple";
		}

		if (element == 3) 
		{
			shotColor.text = "Blue";
		}

		if (element == 4) 
		{
			shotColor.text = "Red";
		}

		if (element == 5) 
		{
			shotColor.text = "Yellow";
		}

		//---------------------------------------------------------------------------------------------------

		if (Input.GetKeyDown (KeyCode.Alpha1)) 
		{
			element = 1;
		}

		if (Input.GetKeyDown (KeyCode.Alpha2)) 
		{
			element = 2;
		}

		if (Input.GetKeyDown (KeyCode.Alpha3)) 
		{
			element = 3;
		}

		if (Input.GetKeyDown (KeyCode.Alpha4)) 
		{
			element = 4;
		}

		if (Input.GetKeyDown (KeyCode.Alpha5)) 
		{
			element = 5;
		}
	}

	void Shooting()
	{
		if (element == 1 && Input.GetMouseButtonDown(0)) 
		{
			//shots [0].SetActive (true);
			GameObject bullet = Instantiate(shots[0],gun.transform.position, gun.transform.rotation) as GameObject;
			bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward*30f,ForceMode.Impulse);
			Destroy (bullet, 6f);
		}

		if (element == 2 && Input.GetMouseButtonDown(0)) 
		{
			GameObject bullet = Instantiate(shots[1],gun.transform.position, gun.transform.rotation) as GameObject;
			bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward*30f,ForceMode.Impulse);
			Destroy (bullet, 6f);
		}

		if (element == 3 && Input.GetMouseButtonDown(0)) 
		{
			GameObject bullet = Instantiate(shots[2],gun.transform.position, gun.transform.rotation) as GameObject;
			bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward*30f,ForceMode.Impulse);
			Destroy (bullet, 6f);
		}

		if (element == 4 && Input.GetMouseButtonDown(0)) 
		{
			GameObject bullet = Instantiate(shots[3],gun.transform.position, gun.transform.rotation) as GameObject;
			bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward*30f,ForceMode.Impulse);
			Destroy (bullet, 6f);
		}

		if (element == 5 && Input.GetMouseButtonDown(0)) 
		{
			GameObject bullet = Instantiate(shots[4],gun.transform.position, gun.transform.rotation) as GameObject;
			bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward*30f,ForceMode.Impulse);
			Destroy (bullet, 6f);
		}

	}
}

