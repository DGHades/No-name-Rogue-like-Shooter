using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject Player;
    public GameObject worldCreator;

    private float width, height;
    // Start is called before the first frame update
    void Start()
    {
        height = worldCreator.GetComponent<MapCreator>().mapHeight;
        width = worldCreator.GetComponent<MapCreator>().mapWidth;
        Player.transform.position = new Vector2(width * 10, height * -10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
