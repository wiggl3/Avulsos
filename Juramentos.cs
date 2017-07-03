using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Juramentos : MonoBehaviour {

	[SerializeField]Text juras;
	[SerializeField]AudioSource [] jurasAudio;
	[SerializeField]ParticleSystem [] lanternas;

	[SerializeField]float red = 100, orange = 100, yellow = 100, green = 100, blue = 100, indigo = 100, saphire = 100;
    float redCharge, orangeCharge, yellowCharge, greenCharge, blueCharge, indigoCharge, saphireCharge;

	[SerializeField]Image redPower, orangePower, yellowPower, greenPower, bluePower, indigoPower, saphirePower;

	// Use this for initialization
	void Start () {
		juras.text = juras.ToString ();
		juras.text = "";



	}
	
	// Update is called once per frame
	void Update ()
	{
		redPower.fillAmount = ((1/red) * redCharge);
		orangePower.fillAmount = ((1/orange) * orangeCharge);
		yellowPower.fillAmount = ((1/yellow) * yellowCharge);
		greenPower.fillAmount = ((1/green) * greenCharge);
		bluePower.fillAmount = ((1/blue) * blueCharge);
		indigoPower.fillAmount = ((1/indigo) * indigoCharge);
		saphirePower.fillAmount = ((1/saphire) * saphireCharge);


		/*red += Time.deltaTime * 3;
		if (red <= 0)
			red = 0;

		orange += Time.deltaTime * 3;
		if (orange <= 0)
			orange = 0;
		
		yellow += Time.deltaTime * 3;
		if (yellow <= 0)
			yellow = 0;
		
		green += Time.deltaTime * 3;
		if (green <= 0)
			green = 0;
		
		blue += Time.deltaTime * 3;
		if (blue <= 0)
			blue = 0;
		
		indigo += Time.deltaTime * 3;
		if (indigo <= 0)
			indigo = 0;

		saphire += Time.deltaTime * 3;
		if (saphire <= 0)
			saphire = 0;
		*/
	}

	void OnTriggerStay (Collider other)
	{
		if (other.gameObject.tag == "LanternaVermelha")
		{
			redCharge += Time.deltaTime * 5;
			if (redCharge >= red)
				redCharge = red;
		}

		//----------------------------------------------------------------------------------

		if (other.gameObject.tag == "LanternaLaranja")
		{
			orangeCharge += Time.deltaTime * 5;
			if (orangeCharge >= orange)
				orangeCharge = orange;
		}

		//----------------------------------------------------------------------------------

		if (other.gameObject.tag == "LanternaAmarela")
		{
			yellowCharge += Time.deltaTime * 5;
			if (yellowCharge >= yellow)
				yellowCharge = yellow;
		}

			
		//----------------------------------------------------------------------------------

		if (other.gameObject.tag == "LanternaVerde")
		{
			greenCharge += Time.deltaTime * 5;
			if (greenCharge >= green)
				greenCharge = green;
		}
			
		//----------------------------------------------------------------------------------

		if (other.gameObject.tag == "LanternaAzul")
		{
			blueCharge += Time.deltaTime * 5;
			if (blueCharge >= blue)
				blueCharge = blue;
		}

		//----------------------------------------------------------------------------------

		if (other.gameObject.tag == "LanternaCiano")
		{
			indigoCharge += Time.deltaTime * 5;
			if (indigoCharge >= indigo)
				indigoCharge = indigo;
		}

		//----------------------------------------------------------------------------------

		if (other.gameObject.tag == "LanternaRosa")
		{
			saphireCharge += Time.deltaTime * 5;
			if (saphireCharge >= saphire)
				saphireCharge = saphire;
		}
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "LanternaVermelha")
		{
			jurasAudio [0].Play ();
			lanternas [0].Play ();
			juras.text = "Com sangue e ira de um vermelho ardente\nArrancado à força de um cadáver ainda quente\nSomado ao nosso ódio que arde infernal\nQueimando a todos-- Eis o destino final!";
		}

		else
		{
			jurasAudio [0].Pause ();
			lanternas [0].Stop ();
		}

		//----------------------------------------------------------------------------------

		if (other.gameObject.tag == "LanternaLaranja")
		{
			jurasAudio [1].Play ();
			lanternas [1].Play ();
			juras.text = "O que é meu, é meu\nE meu e meu e meu\nE meu e meu e meu\nE não seu!";
		}

		else
		{
			jurasAudio [1].Pause ();
			lanternas [1].Stop ();
		}

		//----------------------------------------------------------------------------------

		if (other.gameObject.tag == "LanternaAmarela")
		{
			jurasAudio [2].Play ();
			lanternas [2].Play ();
			juras.text = "No dia mais sombrio, na noite mais brilhante,\nSinta seus medos se tornarem uma luz cortante.\nTodo aquele que o correto tentar barrar\nArderá em chamas quando o poder de Sinestro enfrentar";
		}

		else
		{
			jurasAudio [2].Pause ();
			lanternas [2].Stop ();
		}

		//----------------------------------------------------------------------------------

		if (other.gameObject.tag == "LanternaVerde")
		{
			jurasAudio [3].Play ();
			lanternas [3].Play ();
			juras.text = "No dia mais claro, na noite mais densa\nNenhum mal escapará à minha presença\nTodo aquele que venera o mal há de penar\nQuando o poder do lanterna verde enfrentar.";
		}

		else
		{
			jurasAudio [3].Pause ();
			lanternas [3].Stop ();
		}

		//----------------------------------------------------------------------------------

		if (other.gameObject.tag == "LanternaAzul")
		{
			jurasAudio [4].Play ();
			lanternas [4].Play ();
			juras.text = "No dia de horror, na noite homicida,\nCom o coração aquecido minha alma Ilumina\nQuando a Guerra da Luz parecer perdida,\nA esperança brilha nas estrelas acima!";
		}

		else
		{
			jurasAudio [4].Pause ();
			lanternas [4].Stop ();
		}

		//----------------------------------------------------------------------------------

		if (other.gameObject.tag == "LanternaCiano")
		{
			jurasAudio [5].Play ();
			lanternas [5].Play ();
			juras.text = "Tor lorek san, bor nakka mur,\nNatromo faan tornek wot ur\nTer Lantern ker lo Abin Sur,\nTaan lek lek nok-- Formorrow Sur!";
		}

		else
		{
			jurasAudio [5].Pause ();
			lanternas [5].Stop ();
		}

		//----------------------------------------------------------------------------------

		if (other.gameObject.tag == "LanternaRosa") {
			jurasAudio [6].Play ();
			lanternas [6].Play ();
			juras.text = "Pelos corações perdidos e cheios de horror\nQue na noite mais densa choram solitários de dor\nAceite nosso anel e ajude a combater o terror\nE a tudo conquistar com a Luz Violeta do Amor.";
		}

		else
		{
			jurasAudio [6].Pause ();
			lanternas [6].Stop ();
		}
	}
		
}
