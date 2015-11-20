using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

    private AudioSource[] soundCLips;
    private AudioSource nothing, star; //SFX ARCADE FREE
    
    void Start () {
        this.soundCLips = gameObject.GetComponents<AudioSource>();
        this.nothing = soundCLips[0];
        this.star = soundCLips[1];
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Star")
        {
            this.star.Play();
        }
    }


}
