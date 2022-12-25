using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseDedector : MonoBehaviour
{

    [SerializeField] GameObject openingPanel;
    [SerializeField] GameObject closingPanel;

    private void Start()
    {
        openingPanel = GameObject.Find("Opening");      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("House1"))
        {
            StartCoroutine(ChangeScene(1));
        }
        else if (collision.CompareTag("House2"))
        {
            StartCoroutine(ChangeScene(2));
        }
        else if (collision.CompareTag("House3"))
        {
            StartCoroutine(ChangeScene(3));
        }
        else if (collision.CompareTag("Door")) // Exit House, Go to Platfrom
        {
            StartCoroutine(ChangeScene(4));
        }
    }

    public IEnumerator ChangeScene(int houseNo)  // Scene Numbers:  House1:1, House2:2, House3:3, Platform:4
    {
        PlayerPrefs.SetInt("houseNo", houseNo);
        closingPanel.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(0);
    }


}