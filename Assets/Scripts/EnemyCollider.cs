using UnityEngine;
using System.Collections;

public class EnemyCollider : MonoBehaviour {

    private int lose = 1;
    private GameController gameController;

    void Start ()
    {
        // Finding GameController game object to access methods in GameController script 
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
    }

    void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Player")
        {
            gameController.LoseLife(lose);
            Destroy(gameObject);
        }
    }
  

    
}