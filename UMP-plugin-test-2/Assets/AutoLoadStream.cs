using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoLoadStream : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<UMP.UniversalMediaPlayer>().Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
