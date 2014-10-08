using UnityEngine;
using System.Collections;

public class GotoScene : MonoBehaviour {

	public void GotoMAIN_MENU(){
		Application.LoadLevel(0);
	}
	
	public void GotoABOUT(){
		Application.LoadLevel(1);
	}
	
}
