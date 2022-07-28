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

    public GameObject TileTop;
    public GameObject TileBottom;
    public GameObject TileLeft;
    public GameObject TileRight;
    private bool hasGate = false;
    private bool hasBlockingWall = true;
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
    private void FindNeighbourTiles() 
    {
        RaycastHit2D hit;
        if (Physics2D.Raycast(transform.position, transform.position.x))
        {

        }
    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (TileTop == null || TileBottom == null || TileLeft == null || TileRight == null)
        {
            if (collision.gameObject.transform.position.x < gameObject.transform.position.x)
            {
                //Left
                TileLeft = collision.gameObject;
            }
            else if (collision.gameObject.transform.position.x > gameObject.transform.position.x)
            {
                //Right
                TileRight = collision.gameObject;
            }
            else if (collision.gameObject.transform.position.y < gameObject.transform.position.y)
            {
                //Bot
                TileBottom = collision.gameObject;
            }
            else if (collision.gameObject.transform.position.y > gameObject.transform.position.y)
            {
                //Top
                TileTop = collision.gameObject;
            }
        }
       /* else
        {
            Destroy(gameObject.GetComponent<Collider2D>());
        } */
        
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

    public void SetBlockingWalls(int blockingWallToDel) 
    {
        if (blockingWallToDel == 1)
        {
            Destroy(blockingWallBottom);
        }
        else if (blockingWallToDel == 2)
        {
            Destroy(blockingWallTop);
        }
        else if (blockingWallToDel == 3)
        {
            Destroy(blockingWallRight);
        }
        else if (blockingWallToDel == 4)
        {
            Destroy(blockingWallLeft);
        }
    }
}
