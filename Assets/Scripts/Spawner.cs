using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner: MonoBehaviour
{
	public float timeBetweenSpawns = 1; //Variable die im Inspector 
	private float timer;		                //Variable der unten Time.deltaTime zugewiesen wird
	public GameObject spawnobject;      //Prefab (Original) der geklont wird
	public float height;                //benutzt für Höhenunterschied zwischen spawned objects
	public static float deltaTime;      //benutzt um frameunabhängig das Gamedesign zu coden
	public float destroyTimer;          //könnte man fixed coden für chimneys und Boden aber der dynamische Vordergrund benötigt viel mehr Zeit

    void Start()
	{
		// Start() benutzt um 1 Instanz des Objectes bei Spielbeginn direkt zu spawnen (erlaubt einfachere Position im Scenetab)
		GameObject newspawnobject = Instantiate(spawnobject);
		newspawnobject.transform.position = transform.position + new Vector3 (0,Random.Range(-height, height),0); 
    }

    void Update()
	{
		//spawned neue GameObjects im spezifizierten Zeitintervall
	    if (timer > timeBetweenSpawns)
	    {
	    	//newspawnobject wird eine Kopie des Prefabs zugewiesen
	    	GameObject newspawnobject = Instantiate(spawnobject);
	    	//neuen Instanzen werden die Koordinaten des GameObjects, auf dem das Script liegt, zugewiesen 
	    	//und ein Vektor mit zufälliger y-Koordinate (im Bereich von +-height) wird addiert
	    	newspawnobject.transform.position = transform.position + new Vector3 (0,Random.Range(-height, height),0);
	    	//zerstört Kopien des Prefabs nach der Anzahl an Sekunden, die der Variable destroyTimer zugewiesen wurden
	    	Destroy(newspawnobject, destroyTimer);
	    	//timer wird zurückgesetzt
	    	timer = 0;
	    }
		// der Variable timer wird die frameunabhängige vergangene Zeit addiert 
	    timer += Time.deltaTime;
    }
}
