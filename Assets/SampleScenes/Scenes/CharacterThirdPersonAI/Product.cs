using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Make sure you get rid of the namespace that is automatically generated here.
class Product
{
    //List all the columns of your table here in the same format as below.
    public string id { get; set; }
    public string createdAt { get; set; }
    public string updatedAt { get; set; }
    public string version { get; set; }
    public string ReadingID { get; set; }
    public string WhenReadingRecorded { get; set; }
    public string Location { get; set; }
    public string SafetyCategory { get; set; }
    public string SafetyMeasure { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }
    public bool deleted { get; set; }
}
