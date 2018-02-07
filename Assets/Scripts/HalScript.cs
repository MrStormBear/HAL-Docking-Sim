using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HalScript : MonoBehaviour {

	ShipHandler m_shipHandler;

	void Awake(){
		m_shipHandler = FindObjectOfType<ShipHandler> ();

	}

	public void HALFlirt(int _choice){
		m_shipHandler.GetSelectedShip (_choice);
	}



}
