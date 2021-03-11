using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Descendre : MonoBehaviour
{

    public Transform playerBody;
    public Transform Target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        playerBody.transform.position = Target.transform.position;
        
    }
}
