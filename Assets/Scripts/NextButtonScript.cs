using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class NextButtonScript : MonoBehaviour {

    public Toggle includePhoto;
    public Toggle englishToggle;
    public TMPro.TMP_InputField inviteeName;
    public TMPro.TMP_InputField message;
    public TMPro.TMP_Dropdown music;

    public Canvas canvas;

    private Button buttonNext;

	// Use this for initialization
	void Start () {
        buttonNext = GetComponent<Button>();
        buttonNext.onClick.AddListener(onButtonNextClick);
	}

    void onButtonNextClick()
    {
        if (includePhoto != null)
        {
            GlobalControl.Instance.includePhoto = includePhoto.isOn;
        }
        if (englishToggle != null)
        {
            if (englishToggle.isOn)
            {
                GlobalControl.Instance.languageSelected = 0;
            } 
            else
            {
                GlobalControl.Instance.languageSelected = 1;
            }
        }
        if (inviteeName != null)
        {
            if (inviteeName.text != null && inviteeName.text.Length != 0)
                GlobalControl.Instance.inviteeName = inviteeName.text.ToString();
        }
        if (message != null)
        {
            if (message.text != null && message.text.Length != 0)
                GlobalControl.Instance.message = message.text.ToString();
        }
        if (music != null)
        {
            GlobalControl.Instance.music = music.value;
        }

        SceneManager.LoadScene("Animation Scene");
        canvas.enabled = false;

    }

}
