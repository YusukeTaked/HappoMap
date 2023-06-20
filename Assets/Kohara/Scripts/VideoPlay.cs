using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;


public class VideoPlay : MonoBehaviour
{
    [SerializeField] VideoPlayer videoPlayer;
    
    [SerializeField] Button playbutton;
    [SerializeField] Button pausebutton;

    [SerializeField] Slider slider;
    //[SerializeField] VideoClip[] videoClips;

    // Start is called before the first frame update
    void Start()
    {
        this.playbutton.onClick.AddListener(() =>
        {
            this.videoPlayer.Play();
        });

        this.pausebutton.onClick.AddListener(() =>
        {
            this.videoPlayer.Pause();
        });

        this.slider.onValueChanged.AddListener(value =>
        {
            this.videoPlayer.time = this.videoPlayer.length * value;
        }
        );
    }

    // Update is called once per frame
    void Update()
    {
        this.slider.SetValueWithoutNotify((float)(this.videoPlayer.time / this.videoPlayer.length));
    }
}
