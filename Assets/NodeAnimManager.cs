using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeAnimManager : MonoBehaviour
{
    // Start is called before the first frame update
    static GameObject origLine;
    public int[] nodesOrderNum;
    private List<GameObject> nodeList;
    void Start()
    {
        // foreach(GameObject node in GameObject.FindGameObjectsWithTag("node_anim")){
        //     foreach(int nodenum in nodesOrderNum){
        //         if(node.name == nodenum.ToString()){
        //             nodeList.Add(node);
        //         }
        //     }
        // }
        // foreach(GameObject node in nodeList){
        //     gameObject;
        // }
        // origLine = GameObject.FindGameObjectsWithTag("original_line")[0];
        // GameObject line = Instantiate(origLine, transform.position, Quaternion.identity);
        // line.GetComponent<LineRenderer>().SetPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
