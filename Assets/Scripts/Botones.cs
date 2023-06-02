using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Botones : MonoBehaviour
{
    

    public void abrePaginaMigu()
    {
        Application.OpenURL("https://migu-test.web.app/");
    }

    public void ReiniciaZoom()
    {
        Camera cam = Camera.main;
        cam.transform.position = new Vector3(0f, 142.19f, 0f);
    }

    // 142: 0
    // 122: -3
    // 102: -6
    // 82: -15
    // 62: -24
    // 42: -36

    public void mueveIzquierda()
    {
        Camera cam = Camera.main;
        int posYCam = (int)Mathf.Round(cam.transform.position.y);

        switch (posYCam)
        {
            case 142:
                if (!(cam.transform.position.x <= 0f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(-3f, 0, 0);
                }
            break;

            case 122:
                if (!(cam.transform.position.x <= -3f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(-4f, 0, 0);
                }
            break;

            case 102:
                if (!(cam.transform.position.x <= -6f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(-5f, 0, 0);
                }
            break;

            case 82:
                if (!(cam.transform.position.x <= -15f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(-6f, 0, 0);
                }
            break;

            case 62:
                if (!(cam.transform.position.x <= -24f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(-7f, 0, 0);
                }
            break;

            case 42:
                if (!(cam.transform.position.x <= -36f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(-8f, 0, 0);
                }
            break;
        }

    }


    public void mueveDerecha()
    {
        Camera cam = Camera.main;
        int posYCam = (int)Mathf.Round(cam.transform.position.y);

        switch (posYCam)
        {
            case 142:
                if (!(cam.transform.position.x >= 0f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(3f, 0, 0);
                }
                break;

            case 122:
                if (!(cam.transform.position.x >= 3f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(4f, 0, 0);
                }
                break;

            case 102:
                if (!(cam.transform.position.x >= 6f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(5f, 0, 0);
                }
                break;

            case 82:
                if (!(cam.transform.position.x >= 15f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(6f, 0, 0);
                }
                break;

            case 62:
                if (!(cam.transform.position.x >= 24f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(7f, 0, 0);
                }
                break;

            case 42:
                if (!(cam.transform.position.x >= 36f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(8f, 0, 0);
                }
                break;
        }

    }

    public void mueveArriba()
    {
        Camera cam = Camera.main;
        int posYCam = (int)Mathf.Round(cam.transform.position.y);

        //cam.transform.position = cam.transform.position + new Vector3(0, 0, 3f);

        // 142
        // 122
        // 102
        // 82
        // 62
        // 42

        
        switch (posYCam)
        {
           case 122:
                if (!(cam.transform.position.z >= 3f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(0, 0, 2f);
                }
                break;


            case 102:
                if (!(cam.transform.position.z >= 6f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(0, 0, 3f);
                }
                break;

            case 82:
                if (!(cam.transform.position.z >= 9f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(0, 0, 4f);
                }
                break;

            case 62:
                if (!(cam.transform.position.z >= 18f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(0, 0, 5f);
                }
                break;

            case 42:
                if (!(cam.transform.position.z >= 24f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(0, 0, 6f);
                }
                break;
        
        }
        
    }

    public void mueveAbajo()
    {
        Camera cam = Camera.main;
        int posYCam = (int)Mathf.Round(cam.transform.position.y);



        switch (posYCam)
        {
            case 122:
                if (!(cam.transform.position.z <= -3f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(0, 0, -2f);
                }
                break;


            case 102:
                if (!(cam.transform.position.z <= -6f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(0, 0, -3f);
                }
                break;

            case 82:
                if (!(cam.transform.position.z <= -9f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(0, 0, -4f);
                }
                break;

            case 62:
                if (!(cam.transform.position.z <= -18f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(0, 0, -5f);
                }
                break;

            case 42:
                if (!(cam.transform.position.z <= -24f))
                {
                    cam.transform.position = cam.transform.position + new Vector3(0, 0, -6f);
                }
                break;

        }

    }


    public void zoomMas()
    {
        Camera cam = Camera.main;
        
        if(cam.transform.position.y > 60f)
        cam.transform.position = cam.transform.position + new Vector3(0, -20f, 0);

    }

    public void zoomMenos()
    {
        Camera cam = Camera.main;

        if (cam.transform.position.y < 140f)
            cam.transform.position = cam.transform.position + new Vector3(0, 20f, 0);

    }

    public void ToggleBotones()
    {
        GameObject botonPagina = GameObject.FindGameObjectWithTag("botonPagina");
        Image imagenBotonPagina = botonPagina.GetComponent<Image>();
        GameObject go_textoBotonPagina = botonPagina.transform.GetChild(0).gameObject;
        TextMeshProUGUI textoBotonPagina = go_textoBotonPagina.GetComponent<TextMeshProUGUI>();

        /*

        GameObject botonArriba = GameObject.FindGameObjectWithTag("botonArriba");
        Image imagenBotonArriba = botonPagina.GetComponent<Image>();
        GameObject go_textoBotonArriba = botonPagina.transform.GetChild(0).gameObject;
        TextMeshProUGUI textoBotonArriba = go_textoBotonPagina.GetComponent<TextMeshProUGUI>();

        GameObject botonPagina = GameObject.FindGameObjectWithTag("botonPagina");
        Image imagenBotonPagina = botonPagina.GetComponent<Image>();
        GameObject go_textoBotonPagina = botonPagina.transform.GetChild(0).gameObject;
        TextMeshProUGUI textoBotonPagina = go_textoBotonPagina.GetComponent<TextMeshProUGUI>();

        */


        /*
        Button botonArriba;
        Button botonAbajo;
        Button botonIzquierda;
        Button botonDerecha;
        Button botonMas;
        Button botonMenos;
        Button botonReset;
        */

        if (imagenBotonPagina.enabled)
        {
            imagenBotonPagina.enabled = false;
            textoBotonPagina.enabled = false;
        }
        else
        {
            imagenBotonPagina.enabled = true;
            textoBotonPagina.enabled = true;
        }
    }

    public void Jugar() {

        Application.OpenURL("https://cheerful-fenglisu-41a334.netlify.app/mauricio.html");
        
        /*
        int opcion = Random.Range(1, 3);

        switch( opcion ) {
            
            case 1:
                Application.OpenURL("https://migu-test.web.app/memory");
                break;

            case 2:
                Application.OpenURL("https://www.amazon.com.mx");
                break;

            case 3:
                Application.OpenURL("https://www.twitch.tv");
                break;

          

        }
        */

    
    
    }
}
