using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RayCastTest : MonoBehaviour
{

    public Material[] material;
    private bool hit = false;
    private Text txtRef;

    void OnMouseDown()
    {
        string points = "(" + transform.position.x + ", " + transform.position.y + ", " + transform.position.z + ")";
        txtRef = GameObject.Find("Canvas").GetComponent<Text>();
        txtRef.text = points;
        //GetComponentInChildren<TextMesh>().text = points;
        GetComponent<Renderer>().material = material[0];
        if (hit)
            GetComponent<Renderer>().material = material[0];
        else
            GetComponent<Renderer>().material = material[1];

        hit ^= true;
    }
}