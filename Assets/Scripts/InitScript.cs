using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitScript : MonoBehaviour {

    public Toggle englishToggle;
    public Toggle hindiToggle;
    public Toggle includePhoto;
    public TMPro.TMP_InputField inviteeName;
    public TMPro.TMP_InputField message;
    public TMPro.TMP_Dropdown music;

    // Use this for initialization
    void Start ()
    {
        if (GlobalControl.Instance != null && GlobalControl.Instance.inviteeName != null)
        {
            inviteeName.text = GlobalControl.Instance.inviteeName;
        }
        if (GlobalControl.Instance != null)
        {
            if (GlobalControl.Instance.languageSelected == 0)
            {
                englishToggle.isOn = true;
                hindiToggle.isOn = false;
            }
            else
            {
                englishToggle.isOn = false;
                hindiToggle.isOn = true;
            }
        }
        if (GlobalControl.Instance != null)
        {
            includePhoto.isOn = GlobalControl.Instance.includePhoto;
        }
        if (GlobalControl.Instance != null && GlobalControl.Instance.message != null)
        {
            message.text = GlobalControl.Instance.message;
        }
        if (GlobalControl.Instance != null)
        {
            music.value = GlobalControl.Instance.music;
        }

    }
	
}
