using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// Source: https://cegepvicto.sharepoint.com/sites/Section_27335/Supports%20de%20cours/Forms/AllItems.aspx?id=%2Fsites%2FSection%5F27335%2FSupports%20de%20cours%2FAssets%2FControleurAnimMains%2Ecs&parent=%2Fsites%2FSection%5F27335%2FSupports%20de%20cours%2FAssets&p=true&ga=1
public class ControleurAnimMains : MonoBehaviour
{
    [SerializeField] private InputActionProperty actionTrigger;
    [SerializeField] private InputActionProperty actionGrip;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float valeurTrigger = actionTrigger.action.ReadValue<float>();
        float valeurGrip = actionGrip.action.ReadValue<float>();
        anim.SetFloat("Trigger", valeurTrigger);
        anim.SetFloat("Grip", valeurGrip);
    }
}
