using UnityEngine;
using Pathfinding.Serialization.JsonFx; //make sure you include this using

public class Sketch : MonoBehaviour {
    public GameObject myPrefab;
    // Put your URL here
    public string _WebsiteURL = "http://infosyslab10mobile.azurewebsites.net/tables/WaterPollutionReading?ZUMO-API-VERSION=2.0.0";

    void Start () {
        //Reguest.GET can be called passing in your ODATA url as a string in the form:
        //http://{Your Site Name}.azurewebsites.net/tables/{Your Table Name}?zumo-api-version=2.0.0
        //The response produce is a JSON string
        string jsonResponse = Request.GET(_WebsiteURL);

        //Just in case something went wrong with the request we check the reponse and exit if there is no response.
        if (string.IsNullOrEmpty(jsonResponse))
        {
            return;
        }

        //We can now deserialize into an array of objects - in this case the class we created. The deserializer is smart enough to instantiate all the classes and populate the variables based on column name.
        Product[] products = JsonReader.Deserialize<Product[]>(jsonResponse);

        int totalCubes = products.Length;
        int totalDistance = 5;
        int i = 0;
        //We can now loop through the array of objects and access each object individually
        foreach (Product product in products)
        {
            //Example of how to use the object
            Debug.Log("This products name is: " + product.Location);
            float perc = i / (float)totalCubes;
            i++;
            float x = (float) product.X;
            float y = (float) product.Y;
            float z = (float) product.Z;
            GameObject newCube = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
            //newCube.GetComponent<myCubeScript>().setSize((1.0f - perc) * 2);
            //newCube.GetComponent<myCubeScript>().ratateSpeed = 0;
            //newCube.GetComponentInChildren<TextMesh>().text = product.Location;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
