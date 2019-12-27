using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Grid : MonoBehaviour
{
    float fPosOffset;
    float fScaleOffset;
    float fXPos;
    float fZPos;
    public float fXSize = 1.0f;
    public float fZSize = 1.0f;

    Vector3 v3Pos;
    Vector3 v3Size;

    Transform transform;

    void Start()
    {
        //Gets plane's Transform
        transform = gameObject.GetComponent<Transform>();

        //Sets the position of the plane the bottom left corner is 0, 0, 0 
        fXPos = ((fXSize / 2.0f) * 10);
        fZPos = ((fZSize / 2.0f) * 10);
        fPosOffset = (fXPos / 10);
        v3Pos = new Vector3(fXPos + fPosOffset, 0.0f, fZPos + fPosOffset);
        transform.localPosition = v3Pos;

        //Sets size of Plane
        fScaleOffset = (fXSize) / 10;
        v3Size = new Vector3(fXSize + fScaleOffset, 1.0f, fZSize + fScaleOffset);
        transform.localScale = v3Size;
        
        //transform.localPosition =  
    }
}