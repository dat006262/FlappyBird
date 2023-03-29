using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset_wall : MonoBehaviour
{
    public float MinY;
    public float MaxY;
    public float reset;
    private GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        reset = 30;
     
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Resetwall"))
            obj.transform.position = new Vector3(reset, Random.Range(MinY, MaxY), 0);
    }
}
