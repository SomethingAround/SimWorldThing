using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public enum WallPos    
    {
        Left,
        Right,
        Front,
        Back
    }

public class Wall : MonoBehaviour
{
    float fWallOffset = 0.5f;

    public WallPos side;

    Transform ground;
    // Start is called before the first frame update
    void Start()
    {
        ground = GameObject.FindGameObjectWithTag("Ground").GetComponent<Transform>();
        
        switch (side)
        {
            case WallPos.Left:
                print("Left");
                gameObject.transform.position = new Vector3(fWallOffset, fWallOffset, ground.position.z);
                break;
            case WallPos.Right:
                print("Right");
                break;
            case WallPos.Front:
                print("Front");
                break;
            case WallPos.Back:
                print("Back");
                break;
        }
    }
}