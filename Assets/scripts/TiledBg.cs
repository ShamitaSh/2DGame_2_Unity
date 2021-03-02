using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiledBg : MonoBehaviour
{
    public int textureSize = 64;
    public bool scaleHorizontally = true;
    public bool scaleVertically = true;
    // Start is called before the first frame update
    void Start()
    {
        var newWidth = !scaleHorizontally ? 1 : Mathf.Ceil(Screen.width / (textureSize * pixelperfectcamera.scale));
        var newHeight =!scaleVertically ? 1 : Mathf.Ceil(Screen.height / (textureSize * pixelperfectcamera.scale));
        transform.localScale = new Vector3 (newWidth * textureSize, newHeight * textureSize, 1);
        GetComponent<Renderer>().material.mainTextureScale = new Vector3(newWidth, newHeight, 1);
    }

}  
