// ◆ Date 2015.07.08 wed. Producer : Tomoya Tanzawa
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// ● SoundManagerClass
public class SoundManager : MonoBehaviour
{
    // ▼ Object that music is played
    public GameObject TargetBGMSoundObject;
	public GameObject TargetEFFECTSoundObject;
    // ▼ BGMSliderObject
	public GameObject TargetBGMSlider;
	// ▼ EFFECTSliderObject
	public GameObject TargetEFFECTSlider;
    // ▼ Use this for initialization
    void Start()
    {
    }
    // ▼ Update is called once per frame
    void Update()
    {
		// ▼ Get the first to touch the location
		TargetBGMSoundObject.GetComponent<AudioSource> ().volume = (float)(TargetBGMSlider.GetComponent<Slider> ().value / 10);
		TargetEFFECTSoundObject.GetComponent<AudioSource> ().volume = (float)(TargetEFFECTSlider.GetComponent<Slider> ().value / 10);
	}
}
