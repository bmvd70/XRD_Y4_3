using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCombination : MonoBehaviour
{
    [SerializeField]
    public GameObject button1;
    private bool buttonActivated;

    void Start()
    {
        gameObject.getComponent<Button>().onClick.AddListener(TurnOnAndOff);
        buttonActivated = true;
        button1.SetActive(buttonActivated);
    }

    private void TurnOnAndOff()
    {
        buttonActivated ^= true;
        button1.SetActive(buttonActivated);
    }
}
