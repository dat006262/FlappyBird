using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float flMoveSpeed;
    public float flMoveRange;
    private GameObject obj;
    void Start()
    {

        obj = gameObject;
    }

    // Update is called once per frame
    void Update()
    {

        //Move Qua trái
        obj.transform.Translate(new Vector3(-1 * Time.deltaTime * flMoveSpeed, 0, 0));
    }
}
