using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorDedector : MonoBehaviour
{
    [SerializeField] GameObject openingPanel;
    [SerializeField] GameObject closingPanel;

    private void Start()
    {
        openingPanel = GameObject.Find("Opening");
    }

    public void ExitHouse()     // Door'a basýnca çaðrýlacak fonksyon.
    {
        StartCoroutine(GoToPlatform());
    }

    public IEnumerator GoToPlatform()  // Scene Numbers:  House1:1, House2:2, House3:3, Platform:4
    {
        closingPanel.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(0);
    }
}
