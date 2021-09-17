﻿using UnityEngine;
using UnityEngine.UI;
using Wit.BaiduAip.Speech;

public class AsrDemo : MonoBehaviour
{
    public string APIKey = "";
    public string SecretKey = "";
    public Button StartButton;
    public Button StopButton;
    public Button ReplayButton;
    public Text DescriptionText;

    private AudioClip _clipRecord;
    private AudioSource _audioSource;
    private Asr _asr;

    // Microphone is not supported in Webgl
#if !UNITY_WEBGL

    void Start()
    {
        _audioSource = gameObject.GetComponent<AudioSource>();
        _asr = new Asr(APIKey, SecretKey);
        StartCoroutine(_asr.GetAccessToken());

        StartButton.gameObject.SetActive(true);
        StopButton.gameObject.SetActive(false);
        DescriptionText.text = "";

        StartButton.onClick.AddListener(OnClickStartButton);
        StopButton.onClick.AddListener(OnClickStopButton);
        ReplayButton.onClick.AddListener(OnClickReplayButtion);

        ReplayButton.gameObject.SetActive(false);
    }

    private void OnClickStartButton()
    {
        StartButton.gameObject.SetActive(false);
        StopButton.gameObject.SetActive(true);
        ReplayButton.gameObject.SetActive(false);

        DescriptionText.text = "Listening...";

        _clipRecord = Microphone.Start(null, false, 30, 16000);
    }

    private void OnClickStopButton()
    {
        StartButton.gameObject.SetActive(false);
        StopButton.gameObject.SetActive(false);
        DescriptionText.text = "Recognizing...";
        Microphone.End(null);
        Debug.Log("End recording...");
        var data = Asr.ConvertAudioClipToPCM16(_clipRecord);
        ReplayButton.gameObject.SetActive(true);
        StartCoroutine(_asr.Recognize(data, s =>
        {
            DescriptionText.text = s.result != null && s.result.Length > 0 ? s.result[0] : "未识别到声音";

            StartButton.gameObject.SetActive(true);
        }));
    }

    private void OnClickReplayButtion()
    {
        _audioSource.PlayOneShot(_clipRecord);
    }
#endif
}