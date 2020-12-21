using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTriggerScript : MonoBehaviour
{
    public GameObject paper;
    public GameObject paper2;
    public Material material1;
    public GameObject chooseObject;
    public GameObject thisTask;
    [SerializeField] GameObject Task2;

    [SerializeField] int SceneNum;

    public GameObject soundObject;

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
            Debug.Log("Player Entered");
            thisTask.SetActive(false);
            Task2.SetActive(true);

            SceneManager.LoadScene(SceneNum);
            soundObject.GetComponent<AudioSource>().Play();

        }
        else
        {
            paper.GetComponent<MeshRenderer>().material = material1;
            paper2.GetComponent<MeshRenderer>().material = material1;
            Debug.Log("PlayerEneterereerasdaf");
            thisTask.SetActive(false);
            Task2.SetActive(true);

            SceneManager.LoadScene(SceneNum,LoadSceneMode.Single);
            soundObject.GetComponent<AudioSource>().Play();
        }
    }
}
