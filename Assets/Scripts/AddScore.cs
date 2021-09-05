using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
	//Boxcollider (Trigger) der Scorebox im Chimneyprefab führt diese Funktion aus wenn der Collider von Grinch mit ihm in Berührung kommt 
	protected void OnTriggerEnter2D(Collider2D collision)
	{
		//Zum Score wird 1 addiert
		Score.score++;
	}
}
