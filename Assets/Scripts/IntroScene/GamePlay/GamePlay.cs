using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    [Header("Camera for Gameplay")]
    public GameObject Vcam3;

    public void Awake()
    {
        
    }

    public void PlayDanceButton()
    {
        Vcam3.SetActive(true);
    }
}
