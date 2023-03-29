using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround_Move : MonoBehaviour
{
    // Start is called before the first frame update
    public float flMoveSpeed;
    public float flMoveRange;
    private Vector3 vecOldPosition;
    private GameObject obj;
    void Start()
    {
        //Lấy vị trí cũ
        obj = gameObject;
        vecOldPosition = obj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {   
        //Move Qua trái
        obj.transform.Translate(new Vector3(-1*Time.deltaTime*flMoveSpeed,0,0));
        //Quá range Comback
        if (Vector3.Distance(vecOldPosition, obj.transform.position) > flMoveRange)
            obj.transform.position = vecOldPosition;
    }
}
