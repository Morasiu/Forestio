using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{

    GameObject NaturalMenu;
    public GameObject NeutralMenu;
    GameObject PollutedMenu;

    //public GameObject EarthCenter;
    public LayerMask layer;
    GameObject TargetMenu;
    
    Vector3 hitPosition;
    RaycastHit hit;

    void Update()
    {
        var rightClick = Input.GetKeyDown(KeyCode.Mouse1);
        var leftClick = Input.GetKeyDown(KeyCode.Mouse0);
        if(rightClick || leftClick || Input.GetKey(KeyCode.Mouse2))
            if (TargetMenu != null)
                Destroy(TargetMenu);

        if (rightClick)
        {
            
            
            try
            {
                //wyswietl menu zwiazne z danym polem
                DetectPosition();
                SetTargetMenu();
                ActivateMenu();
            }
            catch(Exception ex)
            {
                Debug.LogError($"Error: {ex.Message}");
                return;
            }
        }
        else if (leftClick)
        {
            try
            {
                DisActiveMenu();
                //zatwierdz akcje
            }
            catch (Exception ex)
            {
                Debug.LogError($"Error: {ex.Message}");
                return;
            }
           
        }
            
    }

    private void DisActiveMenu()
    {
        //TargetMenu = null;
        TargetMenu.SetActive(false);
    }

    private void ActivateMenu()
    {
        //TargetMenu.SetActive(true);
    }

    private void SetTargetMenu()
    {
        var HexaStatus = hit.collider.gameObject.GetComponent<Hex>().HexState;
        Debug.Log($"Hit: {HexaStatus} ");
        
        switch (HexaStatus)
        {
            case HexState.Natural:
                var HexaHasTree = (hit.collider.gameObject.GetComponentInChildren<ItemTree>() != null);
                if (HexaHasTree)
                {
                    print("sadasdsa");
                    NaturalMenu.SetActive(true);
                    TargetMenu = NaturalMenu;
                }
                else
                    //TargetMenu = NeutralMenu;
                    TargetMenu = NaturalMenu; //dla testow dopoki nie mam odpowiedniej grafiki

                break;
            case HexState.Polluted:
                TargetMenu = PollutedMenu;
                break;
            case HexState.Neutral:
                TargetMenu = Instantiate(NeutralMenu,new Vector3(hitPosition.x, hitPosition.y,5f), Quaternion.identity);
                break;
            default:
                Debug.LogError("Uderzony Hex nie ma wartosci state");    
                break;

        }
    }

    private void DetectPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray,out hit,1<<9);
        hitPosition = hit.point*5;
        if(hit.collider != null)
        {
            print(hitPosition);
        }
    }

    #region Natural Menu Actions

    public void OnOakChosen()
    {

    }
    public void OnBushChosen()
    {

    }
    public void OnPineChosen()
    {

    }
    public void OnRedwoodChosen()
    {

    }

    #endregion 


}
