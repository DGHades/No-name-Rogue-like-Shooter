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
}
