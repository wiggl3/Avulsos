using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash : MonoBehaviour {

	[SerializeField]GameObject crashado;
	public enum colorCrystal {red, blue, purple, green};
	public colorCrystal select;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other)
	{
		switch (select) 
		{
		case colorCrystal.blue:
			if (other.gameObject.tag == "ShotBlue") {
				Instantiate (crashado, gameObject.transform.position, Quaternion.identity);
				Destroy (this.gameObject);
			}
			break;

		case colorCrystal.green:
			if (other.gameObject.tag == "ShotGreen") {
				Instantiate (crashado, gameObject.transform.position, Quaternion.identity);
				Destroy (this.gameObject);
			}
			break;

		case colorCrystal.red:
			if (other.gameObject.tag == "ShotRed") {
				Instantiate (crashado, gameObject.transform.position, Quaternion.identity);
				Destroy (this.gameObject);
			}
			break;

		case colorCrystal.purple:
			if (other.gameObject.tag == "ShotPurple") {
				Instantiate (crashado, gameObject.transform.position, Quaternion.identity);
				Destroy (this.gameObject);
			}
			break;
		}
	}
}
