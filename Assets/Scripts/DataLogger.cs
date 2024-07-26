using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataLogger : MonoBehaviour
{
    private string filename = "";
    private string participant_id = "p_test3";
    public enum Device {mouse, touchpad};
    public Device device;
    public enum WIdth {one, two, three};
    public WIdth width;
    public enum Distance{one, two, three};
    public Distance distance;
    public float time = 0.0f;
    public float finalTime = 0.0f;
    public int wrong = 0;
    void Start()
    {
        filename = Application.dataPath + "/" + participant_id + ".csv";   
    }
    public void WriteCSV()
    {
        TextWriter tw = new StreamWriter(filename, true);
        tw.WriteLine("" + participant_id +", "+ device+ ", "+ width + ", "+distance+ ", "+ finalTime + ", "+ wrong);
        tw.Close();
        time = 0;
        wrong = 0;
        finalTime = 0;
    }
}
