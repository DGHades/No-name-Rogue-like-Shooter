using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreator : MonoBehaviour
{
    public GameObject mapTilePosDefiner;
    public int mapWidth = 64;
    public int mapHeight = 64;
    public GameObject baseTile;
    public List<GameObject> posDefiners = new List<GameObject>();
    public List<GameObject> tiles = new List<GameObject>();

    private GameObject temp;
    private int x, y, z = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < mapHeight; i++)
        {
            for (int j = 0; j < mapWidth; j++)
            {
                temp = Instantiate(mapTilePosDefiner, new Vector3(x, y, z), Quaternion.identity);
                posDefiners.Add(temp);
                x += 20;
                
            }
            x = 0;
            y -= 20;
        }
        
        PlaceTiles();
        CheckBorders();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaceTiles() 
    {
        
        foreach (GameObject definer in posDefiners)
        {
           temp = Instantiate(baseTile, definer.transform.position, Quaternion.identity);
           tiles.Add(temp);
        }
    }

    public void CheckBorders() 
    {
        foreach (GameObject tile in tiles)
        {
            if (tile.transform.position.x == 0)
            {
                tile.GetComponent<BaseTile>().SetBorders("Left");
            }
            else if (tile.transform.position.y == (mapHeight-1) * -20)
            {
                tile.GetComponent<BaseTile>().SetBorders("Bottom");
            }
            else if (tile.transform.position.x == (mapWidth-1) * 20)
            {
                tile.GetComponent<BaseTile>().SetBorders("Right");
            }
            else if (tile.transform.position.y == 0)
            {
                tile.GetComponent<BaseTile>().SetBorders("Top");
            }
            else
            {
                tile.GetComponent<BaseTile>().SetBorders("None");
            }
        }
    }
}
