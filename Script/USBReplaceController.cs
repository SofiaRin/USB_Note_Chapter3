using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class USBReplaceController : MonoBehaviour
{
    public Shader m_replacementShader;

    private void OnEnable()
    {
        if(m_replacementShader != null){
            GetComponent<Camera>().SetReplacementShader(m_replacementShader,"RenderType");
        }
    }

    private void OnDisable(){
        GetComponent<Camera>().ResetReplacementShader();

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
