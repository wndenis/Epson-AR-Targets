using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class LineManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var lr = GetComponent<LineRenderer>();
        var text = GetComponent<TextMesh>();
        lr.startColor = text.color;
        lr.endColor = Color.white;
        lr.positionCount = 1;
        lr.SetPosition(0, transform.position);
        foreach (Transform child in transform)
        {
            lr.positionCount++;
            lr.SetPosition(lr.positionCount-1, child.position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
