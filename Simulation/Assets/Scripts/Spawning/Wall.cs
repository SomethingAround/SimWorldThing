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

    public WallPos side;

    Transform transform;

    Transform ground;
    // Start is called before the first frame update
    void Start()
    {
        ground = GameObject.FindGameObjectWithTag("Ground").GetComponent<Transform>();

        switch (side)
        transform = gameObject.GetComponent<Transform>();
        {
            case WallPos.Left:
                print("hello");
                break;
            case WallPos.Right:
                print("hello");
                break;
            case WallPos.Front:
                print("hello");
                break;
            case WallPos.Back:
                print("hello");
                break;
        }
        transform.localPosition = ground.localPosition;
    }
}
