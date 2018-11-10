using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MakeCheckPoints2 : MonoBehaviour {

    
    public float waitTime = 0.2f;
    List<Vector3> positionlist = new List<Vector3>();

    private void Start()
    {
        StartCoroutine(DrawPath(waitTime));
    }

    IEnumerator DrawPath(float timeRate)
    {
        while (true)
        {
            positionlist.Add(transform.position);
           // StreamWriter mysw = new StreamWriter("Assets/Resources/abc.txt");
           // mysw.WriteLine(transform.position.x + "," + transform.position.y + "," + transform.position.z);
            //mysw.Close();
            // wait before do this again
            yield return new WaitForSeconds(timeRate);
        }
    }

    void OnApplicationQuit()
    {
        StreamWriter mysw = new StreamWriter("Assets/Resources/abc.txt");

        foreach(Vector3 cp in positionlist)
        {
            mysw.WriteLine(cp.x + "," + cp.y + "," + cp.z);
        }

        mysw.Close();
    }
}
