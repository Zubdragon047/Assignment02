using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    private static List<int> completed = new List<int>();   
    private bool use;
    private int nextSceneIndex;
    public void LoadScene()
    {
        if(completed.Count == 8)
        {
            Application.Quit();
        }else{
            use = false;
            while(!use)
            {
                nextSceneIndex = Random.Range(1,9);
                if(!completed.Contains(nextSceneIndex))
                {
                    use = true;
                    completed.Add(nextSceneIndex);
                }
            }
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
