using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Untagged"||other.tag=="whiteball") return;
        switch (this.tag)
        {
            default:
            case "redt":
                other.gameObject.tag = "redball";
                other.gameObject.GetComponent<MeshRenderer>().material = Resources.Load<Material>("Materials/red");
                break;
            case "bluet":
                other.gameObject.tag = "blueball";
                other.gameObject.GetComponent<MeshRenderer>().material = Resources.Load<Material>("Materials/blue");
                break;
            case "yellowt":
                other.gameObject.tag = "yellowball";
                other.gameObject.GetComponent<MeshRenderer>().material = Resources.Load<Material>("Materials/yellow");
                break;
            case "oringet":
                other.gameObject.tag = "oringeball";
                other.gameObject.GetComponent<MeshRenderer>().material = Resources.Load<Material>("Materials/oringe");
                break;
        }
    }
}
