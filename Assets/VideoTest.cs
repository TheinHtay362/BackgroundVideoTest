using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoTest : MonoBehaviour
{
    public GameObject background1;
    public GameObject background2;

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
            background1.SetActive(false);
            background2.SetActive(true);
        }
        else
        {
            background2.SetActive(false);
            background1.SetActive(true);
        }
    }
}
