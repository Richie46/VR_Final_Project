using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggerScript : MonoBehaviour
{
    public GameObject paper;
    public GameObject paper2;
    public Material material1;
    public GameObject chooseObject;
    public GameObject thisTask;
    public GameObject Task2;



    void Start()
    {
        Task2.SetActive(false);

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == chooseObject)
        {
            paper.GetComponent<MeshRenderer>().material = material1;
            paper2.GetComponent<MeshRenderer>().material = material1;
            Debug.Log("Task Completed");
            thisTask.SetActive(false);
            Task2.SetActive(true);
        }
        else
        {
            paper.GetComponent<MeshRenderer>().material = material1;
            paper2.GetComponent<MeshRenderer>().material = material1;
            Debug.Log("Task Completed");
            thisTask.SetActive(false);
            Task2.SetActive(true);
        }
    }
}
