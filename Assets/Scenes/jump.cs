using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(Vector2.up * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
