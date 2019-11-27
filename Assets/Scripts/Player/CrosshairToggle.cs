using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairToggle : MonoBehaviour
{
    public Texture2D defaultCrosshairImage;
    public Vector2 arrowRegPoint;

    public Texture2D attackCrosshairImage;
    public Vector2 attackingRegPoint;

    public Texture2D interactCrosshairImage;
    public Vector2 interactRegPoint;

    private Vector2 mouseReg;
    private Vector2 mouseCoord;
    private Texture mouseTex;

    private void OnDisable()
    {
        Cursor.visible = true;
    }
    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
    }

    private void OnGUI()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            switch (hit.collider.tag)
            {
                case "Enemy":
                    mouseTex = attackCrosshairImage;
                    mouseReg = attackingRegPoint;
                    break;
                case "Interact":
                    mouseTex = interactCrosshairImage;
                    mouseReg = interactRegPoint;
                    break;
                default:
                    mouseTex = defaultCrosshairImage;
                    mouseReg = arrowRegPoint;
                    break;
            }
        }
        else
        {
            mouseTex = defaultCrosshairImage;
            mouseReg = arrowRegPoint;
        }

        mouseCoord = Input.mousePosition;
        GUI.DrawTexture(new Rect(mouseCoord.x - mouseReg.x, Screen.height - mouseCoord.y - mouseReg.y, mouseTex.width, mouseTex.height), mouseTex, ScaleMode.StretchToFill, true, 10.0f);
    }
}
