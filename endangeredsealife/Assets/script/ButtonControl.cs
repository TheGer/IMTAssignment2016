using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonControl : MonoBehaviour {


	public void newGameButton(){
		SceneManager.LoadScene ("easygamemode");
	}

	public void DifficultyButton(){
		SceneManager.LoadScene ("levels");
	}

	public void MainMenuButton(){
		SceneManager.LoadScene("mainmenu");
	}

	public void Controls(){
		SceneManager.LoadScene ("controls");
	}

	public void EasyLevel(){
		SceneManager.LoadScene("easygamemode");
	}

	public void MediumLevel(){
		SceneManager.LoadScene ("mediumgamemode");
	}

	public void HardLevel(){
		SceneManager.LoadScene ("hardgamemode");
	}

	public void BackToMenu(){
		SceneManager.LoadScene ("mainmenu");
	}

	public void JostickButton(){
		SceneManager.LoadScene ("controls");
	}
	public void NextControlMenu(){
		SceneManager.LoadScene ("controlspart2");
	}

	public void NextLevel(){
		SceneManager.LoadScene (State.CurrentLevel + 1);
	}		
}
