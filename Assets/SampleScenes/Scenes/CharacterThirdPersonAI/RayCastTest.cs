using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RayCastTest : MonoBehaviour
{

    public Material[] material;
    private bool hit = false;
    private Text txtRef;
    public string location;
    public string ecologicalValue;
    public string historicalSignificance;

    void OnMouseDown()
    {
        string points = "Coordinates\nX: " + transform.position.x + "\nY: "
            + transform.position.y + "\nZ: " + transform.position.z + "\n\nLocation: " + location
            + "\nEcological Value: " + ecologicalValue + "\nHistorical Significance: " + historicalSignificance;
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