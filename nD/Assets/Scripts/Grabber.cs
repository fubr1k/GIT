using UnityEngine;
using System.Collections;

public class Grabber : MonoBehaviour {

	private bool _bgrabbed = false;

	void Start () {
	
	}
	
	
	void Update () {
        
        if (_bgrabbed && Input.GetKeyDown("f") && gameObject.transform.root.gameObject.tag == "Player")
        {
            transform.parent = null;
            _bgrabbed = false;

        }
    }

    void OnTriggerStay(Collider _col_)
    {
       
        if (_col_.gameObject.tag == "Grabber" && Input.GetKeyDown("g") && !_bgrabbed)
        {
            gameObject.transform.parent = _col_.transform;
            _bgrabbed = true;
        }
        
    }
}
