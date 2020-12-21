using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TriggerScript : MonoBehaviour
{
    public GameObject paper;
    public GameObject paper2;
    public Material material1;
    public GameObject chooseObject;
    public GameObject thisTask;
    public GameObject Task2;

    [SerializeField] GameObject soundObject;


    void Start()
    {
        Task2.SetActive(false);

    }
   void OnTriggerEnter (Collider col)
    {
        if (col.gameObject == chooseObject)
        {
            paper.GetComponent<MeshRenderer>().material = material1;
            paper2.GetComponent<MeshRenderer>().material = material1;
            Debug.Log("Task Completed");
            thisTask.SetActive(false);
            Task2.SetActive(true);
        }
        if(col.gameObject != chooseObject)
        {

            SceneManager.LoadScene(2,LoadSceneMode.Single);
            soundObject.GetComponent<AudioSource>().Play();
        }
    }
}
