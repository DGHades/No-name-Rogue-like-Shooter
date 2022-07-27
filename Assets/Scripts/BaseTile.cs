using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTile : MonoBehaviour
{
    [Header("Prefab Objects")]
    public GameObject wallTopLeft;
    public GameObject wallTopRight;
    public GameObject wallBottomLeft;
    public GameObject wallBottomRight;
    public GameObject blockingWallLeft;
    public GameObject blockingWallRight;
    public GameObject blockingWallTop;
    public GameObject blockingWallBottom;
    public GameObject gateLeft;
    public GameObject gateRight;
    public GameObject gateTop;
    public GameObject gateBottom;
    public GameObject borderLeft;
    public GameObject borderRight;
    public GameObject borderTop;
    public GameObject borderBottom;

    private bool hasGate = false;
    private bool hasBlockingWall = false;
    // Start is called before the first frame update
    void Start()
    {
        if (!hasGate)
        {
            Destroy(gateTop);
            Destroy(gateBottom);
            Destroy(gateLeft);
            Destroy(gateRight);
        }
        if (!hasBlockingWall)
        {
            Destroy(blockingWallBottom);
            Destroy(blockingWallLeft);
            Destroy(blockingWallRight);
            Destroy(blockingWallTop);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetBorders(string side) 
    {
        if (side == "TopLeft")
        {
            Destroy(borderBottom);
            Destroy(borderRight);
        }
        if (side == "TopRight")
        {
            Destroy(borderBottom);
            Destroy(borderLeft);
        }
        if (side == "BottomLeft")
        {
            Destroy(borderTop);
            Destroy(borderRight);
        }
        if (side == "BottomRight")
        {
            Destroy(borderTop);
            Destroy(borderLeft);
        }
        if (side == "Top")
        {
            Destroy(borderBottom);
            Destroy(borderLeft);
            Destroy(borderRight);
        }
        if (side == "Bottom")
        {
            Destroy(borderTop);
            Destroy(borderLeft);
            Destroy(borderRight);
        }
        if (side == "Left")
        {
            Destroy(borderBottom);
            Destroy(borderTop);
            Destroy(borderRight);
        }
        if (side == "Right")
        {
            Destroy(borderBottom);
            Destroy(borderTop);
            Destroy(borderLeft);
        }
        if (side == "None")
        {
            Destroy(borderRight);
            Destroy(borderBottom);
            Destroy(borderTop);
            Destroy(borderLeft);
        }
    }
}
