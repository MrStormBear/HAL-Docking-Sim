using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIHandler : MonoBehaviour {

	public GameObject m_winScreen;
	public GameObject m_loseScreen;

	public void ShowEnd(bool _win){
		if ( _win ) {
			m_winScreen.SetActive ( true );
		} else {
			m_loseScreen.SetActive ( false );
		}
	}

	public void ShowEndScreen(){
		m_loseScreen.SetActive ( true );
	}

	public void HideWinScreen(){
		m_winScreen.SetActive ( false );
	}

	public void ResetEverything(){
		SceneManager.LoadScene ( 0 );
	}
}
