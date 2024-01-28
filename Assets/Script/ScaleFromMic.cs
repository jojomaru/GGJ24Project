using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleFromMic : MonoBehaviour
{
    public AudioSource audioSrc;
    public Vector2 minScale;
    public Vector2 maxScale;
    public AudioDetection detector;

    public float loudnessSensibility = 100;
    public float threshold = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float loudness = detector.GetLoudnessfromMic() * loudnessSensibility;

        if(loudness < threshold) loudness = 0;
        Debug.Log("IT FUCKING WORKS!!");
        //lerp value from min to maxscale
        transform.localScale = Vector3.Lerp(minScale, maxScale, loudness);
    }
}
