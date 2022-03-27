using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
       // transform.position = player.position + offset;
       //ให้กล้องอยู่ตรงกลางอย่างเดียว  
         Vector3 targetPos = player.position + offset;
         targetPos.x = 0;
         transform.position = targetPos;
    }
}
