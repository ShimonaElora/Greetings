using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationSceneScript : MonoBehaviour {

    public TMPro.TextMeshPro inviteeName;
    public TMPro.TextMeshPro message;

	// Use this for initialization
	void Start () {
        if (GlobalControl.Instance != null && GlobalControl.Instance.inviteeName != null)
        {
            inviteeName.text = GlobalControl.Instance.inviteeName;
        }
        if (GlobalControl.Instance != null && GlobalControl.Instance.message != null)
        {
            message.text = GlobalControl.Instance.message;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
