using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class AudioDetection : MonoBehaviour
{
    public int sampleWindow = 64;
    private AudioClip micClip;

    // Start is called before the first frame update
    void Start()
    {
        RequestMicrophonePermission();
        StartCoroutine(WaitForMicrophonePermission());

        MicToAudioClip();
    }

    void RequestMicrophonePermission()
    {
        if (!Permission.HasUserAuthorizedPermission(Permission.Microphone))
        {
            Permission.RequestUserPermission(Permission.Microphone);
        }
    }

    IEnumerator WaitForMicrophonePermission(){
        while (!Permission.HasUserAuthorizedPermission(Permission.Microphone))
        {
            yield return null;
        }
    }

    public void MicToAudioClip(){
        string micName = Microphone.devices[0];
        micClip = Microphone.Start(micName, true, 20, AudioSettings.outputSampleRate);
    }

    public float GetLoudnessfromMic(){
        return GetLoudnessFromAudioClip(Microphone.GetPosition(Microphone.devices[0]), micClip);
    }

    public float GetLoudnessFromAudioClip(int clipPos, AudioClip clip){
        int startPos = clipPos - sampleWindow;

        if(startPos < 0) return 0;
        
        float[] waveData = new float[sampleWindow];
        clip.GetData(waveData, startPos);

        //compute loudness
        float totalLoud = 0;

        for(int i = 0; i <sampleWindow; i++){
            totalLoud += Mathf.Abs(waveData[i]);
        }

        return totalLoud / sampleWindow;
    }
}
