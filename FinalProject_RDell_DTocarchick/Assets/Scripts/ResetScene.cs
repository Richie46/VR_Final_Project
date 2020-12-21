using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ResetScene : MonoBehaviour
{
    public GameObject chooseObject;
    public GameObject thisTask;
    public int Scenenum;


    void OnTriggerEnter(Collider col)
    {
        this.gameObject.GetComponent<ImageFade>().Fade();
        Debug.Log("SleepActivaated");
        thisTask.SetActive(false);
        SceneManager.LoadScene(Scenenum, LoadSceneMode.Single);
    }
}

