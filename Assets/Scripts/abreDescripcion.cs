using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class abreDescripcion : MonoBehaviour
{
    public GameObject cubo;
    public string tagObjeto;
    public TextMeshProUGUI label;
    public Image imagenBotonJugar;
    public TextMeshProUGUI textoBotonJugar;

    // Start is called before the first frame update
    void Start()
    {
        label.text = "";

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cubo = getClickedObject(out RaycastHit hit);
            if(cubo != null)
            {
                tagObjeto = cubo.tag;
                
                if(tagObjeto != "Untagged")
                {
                    label.text = tagObjeto;

                    if (!imagenBotonJugar.enabled)
                    {
                        imagenBotonJugar.enabled = true;
                        textoBotonJugar.enabled = true;
                    }
                }
                
            }
            


        }
        if (Input.GetMouseButtonUp(0))
        {
            print("click is off");
        }

    }

    GameObject getClickedObject(out RaycastHit hit)
    {
        GameObject target = null;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast ( ray.origin, ray.direction * 10, out hit))
        {
            if (!isPointerOverUIObject())
            {
                target = hit.collider.gameObject;
            }
        }
        return target;
    }

    bool isPointerOverUIObject()
    {
        PointerEventData ped = new PointerEventData(EventSystem.current);

        ped.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        List <RaycastResult> results = new List <RaycastResult>();

        EventSystem.current.RaycastAll(ped, results);

        return results.Count > 0;
    }
    
}
