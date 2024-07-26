using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class colorChanger : MonoBehaviour
{
    SpriteRenderer sr;
    public InputHandler inputHandler;
    public DataLogger dataLogger;
    private GameObject nextObject;
    public SceneChanger sceneChanger;
    
   
    public void changeColor(GameObject g)
    {
        sr = g.GetComponent<SpriteRenderer>();
        sr.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        dataLogger.WriteCSV();
    }

    public void colorNextCircle(string current)
    {
        int next = int.Parse(current);
        next += 4;
        if(next > 9)
        {
            next = next - 9;
        }
        if(next == 1)
        {
            sceneChanger.LoadScene();
            return;
        }
        nextObject = GameObject.Find(next.ToString());
        sr = nextObject.GetComponent<SpriteRenderer>();
        sr.color = new Color(1f, 0f, 0f, 1f);

    }
}
