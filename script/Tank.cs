using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Tank : NetworkBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(!isLocalPlayer)
            return;

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Rotate(0, 0, -h * 180 * Time.deltaTime);
        transform.Translate(0, v * 4 * Time.deltaTime,0);
    }
    public override void OnStartLocalPlayer(){
        GetComponent<SpriteRenderer>().color = Color.red;
    }
}
