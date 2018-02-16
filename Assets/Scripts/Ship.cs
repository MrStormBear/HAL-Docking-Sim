using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {

	//Move the animator to the ship handler in the future

	ShipHandler m_parent;
	public GameObject m_shipSprite;
//	SpriteRenderer m_spriteRend;
//	bool m_selected;
	public float m_moveSpeed = 0.5f;
	public int m_numOfChoices = 3;
	public AnimationCurve m_curve;
	float m_moveSpeedReversed;
	float m_totalDistance;
	float m_segDistance;
	Vector3 m_heading;
	Vector3 m_direction;

	Vector3 m_moveToPos;

	void Start(){
//		m_spriteRend = GetComponent<SpriteRenderer> ();
		GetDirection ();
		m_moveSpeedReversed = 1 / m_moveSpeed;
	}

//	void OnMouseDown(){
//		m_parent.SetSelectedShip ( this );
//	}

	void GetDirection(){
//		Debug.Log ( name );
		m_heading = m_parent.GetHalPos () - transform.position;
		m_totalDistance = m_heading.magnitude;
		m_direction = m_heading / m_totalDistance;
		m_segDistance = m_totalDistance / m_numOfChoices;

	}

	public void DetermineResponse(int _choice){
		switch ( _choice ) {
		case 0:
			Attracted ();
			break;
		case 1:
			Repulsed ();
			break;
		default:
			break;
		}
	}

	public void Attracted(){
//		Debug.Log ( "Attracted!" );
		m_moveToPos = transform.position + m_direction * m_segDistance;
		StartCoroutine ( AnimateShip() );
	}

	public void FlyTowardsHAL(){
		m_moveToPos = m_parent.GetHalPos ();
		StartCoroutine ( AnimateShip () );
	}

	public void Repulsed(){
//		Debug.Log ( "Repulsed!" );
		m_moveToPos = transform.position - m_direction * m_segDistance;
		StartCoroutine ( AnimateShip() );
	}

	IEnumerator AnimateShip(){
		Debug.Log ( "startanim" );
		m_parent.StartAnimating ();
		float t = 0f;
		Vector3 defPos = transform.position;
		while ( t < 0.98 ) {
//			Debug.Log ( t );
			t += Time.deltaTime * m_moveSpeedReversed * m_curve.Evaluate(t);
			transform.position = Vector3.Lerp ( defPos, m_moveToPos, t );
			yield return null;
		}
		transform.position = Vector3.Lerp ( defPos, m_moveToPos, 1 );
		m_parent.FinishedAnimating ();
	}

	public void SetParent(ShipHandler _sHandler){
		m_parent = _sHandler;
	}
	public void DisableShip(){
		gameObject.SetActive ( false );
	}
//	public void IsSelected(bool _selected){
//		if ( _selected ) {
//			m_spriteRend.color = Color.red;
//		} else {
//			m_spriteRend.color = Color.white;
//		}
//	}
}
