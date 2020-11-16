using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ButtonMonobehaviour : MonoBehaviour
{
    private Image image;
    private void OnMouseEnter()
    {
        GetComponent<Image>().tintColor = Color.white;
    }
}
