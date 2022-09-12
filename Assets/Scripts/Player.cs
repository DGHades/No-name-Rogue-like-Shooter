using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Crosshair;
    public GameObject PlayerOptic;


    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(Vector3.left * 0.1f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(Vector3.up * 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(Vector3.down * 0.1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(Vector3.right * 0.1f);
        }
        MoveCrosshair();
    }
    void MoveCrosshair() 
    {
        Vector2 mousePosition = Input.mousePosition;
        Crosshair.transform.position = mousePosition;
        PlayerOptic.transform.rotation = Quaternion.LookRotation(Vector3.forward, Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);
    }
}
