using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteScript : MonoBehaviour
{
    [SerializeField] Image SoundOnIcon;
    [SerializeField] Image SoundOffIcon;
    [SerializeField] AudioSource audioSource;
    private bool muted = false;
    
    void Start() 
    {
        if (!PlayerPrefs.HasKey("muted")) 
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else 
        {
            Load();
        }
        UpdateButtonIcon();
        AudioListener.pause = muted;
        
    }

    public void OnButtonPress() 
    {
        if(muted == false) 
        {
            muted = true;
            AudioListener.pause = true;
        }
        else 
        {
            muted = false;
            AudioListener.pause = false;
        }
        Save();
        UpdateButtonIcon();
    }
    private void UpdateButtonIcon() 
    {
        if (muted == false)
        {
            SoundOnIcon.enabled = true;
            SoundOffIcon.enabled = false;
        }
        else 
        {
            SoundOnIcon.enabled = false;
            SoundOffIcon.enabled = true;
        }

    }

    private void Load() 
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void Save() 
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
}
