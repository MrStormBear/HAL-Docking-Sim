using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIHandler : MonoBehaviour {

//	public GameObject m_winScreen;
	public GameObject m_loseScreen;

	public void ShowEndScreen(){
		m_loseScreen.SetActive ( true );
	}

	public void ResetEverything(){
		SceneManager.LoadScene ( 0 );
	}
}
