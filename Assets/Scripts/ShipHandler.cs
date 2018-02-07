using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipHandler : MonoBehaviour {

	List<Ship> m_shipList;
	Vector3 m_halPos;
	Ship m_selectedShip;
	UIHandler m_uiHandler;

	void Awake(){
		m_shipList = new List<Ship> ();
		foreach ( Ship ship in FindObjectsOfType<Ship>() ) {
			ship.SetParent ( this );
			m_shipList.Add ( ship );

		}
		m_halPos = FindObjectOfType<HalScript> ().transform.position;
		m_uiHandler = FindObjectOfType<UIHandler> ();
	}

	public Vector3 GetHalPos(){
		return m_halPos;
	}

	public void StartAnimating(){
		m_uiHandler.ShowHideUI ( false );
	}

	public void FinishedAnimating(){
		m_uiHandler.ShowHideUI ( true );
	}

	public void SetSelectedShip(Ship _ship){
		if ( m_selectedShip != null ) {
			m_selectedShip.IsSelected ( false );
		}
		m_selectedShip = _ship;
		m_selectedShip.IsSelected ( true );
		Debug.Log ( m_selectedShip.name );
	}

	public void GetSelectedShip(int _choice){
		if ( m_selectedShip != null ) {
			m_selectedShip.DetermineResponse ( _choice );
		}
	}
}
