using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //wird gebraucht für text objects

public class Score : MonoBehaviour
{
	public static int score = 0; //static damit die integer überall geändert wird
	public Text highscore;
	public Text anzahl;  //Score wird 2mal im normalen Spiel bzw Scorecanvas (1 normal + 1 als Schatten) und einmal im GameOverCanvas benutzt
	public Text anzahl1;
	public Text anzahl2;
   
    void Start()
	{
		//score wird beim ersten Frame zurückgesetzt
		score = 0;
		//dem Textobject Highscore wird die Integer Highscore zugewiesen nachdem sie in einen String umgewandelt wurde
	    highscore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }

	//FixedUpdate für Frameindependence weil Update nicht funktioniert hat
	void FixedUpdate()
	{
		//eigene Method weil ich mich 3x wiederholt habe
		ScoreToString();
		//Highscore wird geupdated wenn ein höherer Score erzielt wird als gegenwärtig Highscore ist
	    if (score > PlayerPrefs.GetInt("Highscore", 0))
		    {
		    PlayerPrefs.SetInt("Highscore", score);
		    highscore.text = score.ToString();
		    }
	    
    }
    
	void ScoreToString()
	{
		//3x Integer in String umgewandelt
		anzahl.text = score.ToString();
		anzahl1.text = score.ToString();
		anzahl2.text = score.ToString();
	}
}
