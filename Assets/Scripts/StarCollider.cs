using UnityEngine;
using System.Collections;

public class StarCollider : MonoBehaviour {

    private int points = 100;
    private GameController gameController;

    // Use this for initialization
    void Start () {

        // Finding GameController game object to access methods in GameController script 
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameController.GainScore(points);
            Destroy(gameObject);
        }
    }
}
