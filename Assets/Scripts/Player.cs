using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Crosshair;
    public GameObject PlayerOptic;
    public LineRenderer AimLine;
    private Vector3 LineStartPos,LineEndPos;
    void Start()
    {
        
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
        DrawAimLine();
    }
    void DrawAimLine()
    {
        AimLine.gameObject.SetActive(true);
        Vector3 LineStartPos = transform.position;
        Vector3 LineEndPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        AimLine.SetVertexCount(2);
        AimLine.SetPosition(0, LineStartPos);
        AimLine.SetPosition(1, LineEndPos);
    }
    void MoveCrosshair() 
    {
        Vector2 mousePosition = Input.mousePosition;
        Crosshair.transform.position = mousePosition;
        PlayerOptic.transform.rotation = Quaternion.LookRotation(Vector3.forward, Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);
    }
}
