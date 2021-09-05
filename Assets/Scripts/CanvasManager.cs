using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //benötigt um Szene neuzuladen

public class CanvasManager : MonoBehaviour
{
	//Canvas mit Highscore etc
	public GameObject gameOverCanvas; 
	//Canvas der Score im Spiel hochzählt
	public GameObject scoreCanvas;    
	
    void Start()
	{
		//Zeit im Spiel = Echtzeit
	    Time.timeScale = 1;
    }


	public void GameOver() //wird im Grinchscript gecalled
	{
		//Canvas mit Score wird ausgeschalten
		scoreCanvas.SetActive(false);
		//Canvas mit Highscore und PlayButton geht an
		gameOverCanvas.SetActive(true);
		//Spielgeschehen wird pausiert 
		//(sonst spawnen und despawnen endlos Objekte und Grinch Y-Koordinate geht gegen -∞)
		Time.timeScale = 0;
	}
	public void Replay()
	{
		//Funktion die OnClick vom PlayButton gecalled wird um die Szene neuzuladen
		SceneManager.LoadScene(0);
	}
}
