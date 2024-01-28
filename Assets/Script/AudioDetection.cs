using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDetection : MonoBehaviour
{
    public int sampleWindow = 64;
    private AudioClip micClip;

    // Start is called before the first frame update
    void Start()
    {
        MicrToAudioClip();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MicrToAudioClip(){
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
