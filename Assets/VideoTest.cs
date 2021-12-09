using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoTest : MonoBehaviour
{
    public GameObject background1;
    public GameObject background2;
    public RawImage rawImage1;
    public RawImage rawImage2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickChangeButton()
    {
        Debug.Log("work");
        if(background1.activeInHierarchy == true)
        {
            //background1.GetComponent<VideoPlayer>().Pause();
            //background2.GetComponent<VideoPlayer>().Play();
            rawImage1.gameObject.SetActive(false);
            background1.SetActive(false);

            rawImage2.gameObject.SetActive(true);
            background2.SetActive(true);

        }
        else
        {
            //background2.GetComponent<VideoPlayer>().Pause();
            //background1.GetComponent<VideoPlayer>().Play();
            rawImage2.gameObject.SetActive(false);
            background2.SetActive(false);

            rawImage1.gameObject.SetActive(true);
            background1.SetActive(true);

        }
    }
}
