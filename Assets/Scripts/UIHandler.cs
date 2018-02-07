using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIHandler : MonoBehaviour {

	public GameObject m_buttons;

	public void ShowHideUI(bool _show){
		m_buttons.SetActive ( _show );
	}
}
