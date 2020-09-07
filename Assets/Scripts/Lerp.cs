using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    float result = Mathf.Lerp(3f, 5f, 0.5f);

     // Start is called before the first frame update
    void Start()
    {
        Debug.Log(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
