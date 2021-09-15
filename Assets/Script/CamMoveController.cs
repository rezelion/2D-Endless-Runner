using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMoveController : MonoBehaviour
{
    [Header("Position")]
    public Transform Player;
    public float horizontalOffSet;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;
        newPos.x = Player.position.x + horizontalOffSet;
        transform.position = newPos;
    }
}
