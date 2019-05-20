using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*This script is for skins
 * Add new lines for new skins
 */
public class choosematerial : MonoBehaviour
{
    public static GameObject[] objs;

    public Material[] material;
    private void Start()
    {

        choosematerial.objs = GameObject.FindGameObjectsWithTag("Player");
        switch (PlayerPrefs.GetInt("choose"))
        {
            case 1:
                foreach (GameObject gameObject in choosematerial.objs)
                {
                    gameObject.transform.GetComponent<MeshRenderer>().material = this.material[0];
                }
                break;
            case 2:
                foreach (GameObject gameObject2 in choosematerial.objs)
                {
                    gameObject2.transform.GetComponent<MeshRenderer>().material = this.material[1];
                }
                break;
            case 3:
                foreach (GameObject gameObject3 in choosematerial.objs)
                {
                    gameObject3.transform.GetComponent<MeshRenderer>().material = this.material[2];
                }
                break;
            case 4:
                foreach (GameObject gameObject4 in choosematerial.objs)
                {
                    gameObject4.transform.GetComponent<MeshRenderer>().material = this.material[3];
                }
                break;
            case 5:
                foreach (GameObject gameObject5 in choosematerial.objs)
                {
                    gameObject5.transform.GetComponent<MeshRenderer>().material = this.material[4];
                }
                break;
            case 6:
                foreach (GameObject gameObject6 in choosematerial.objs)
                {
                    gameObject6.transform.GetComponent<MeshRenderer>().material = this.material[5];
                }
                break;
            case 7:
                foreach (GameObject gameObject7 in choosematerial.objs)
                {
                    gameObject7.transform.GetComponent<MeshRenderer>().material = this.material[6];
                }
                break;
            case 8:
                foreach (GameObject gameObject8 in choosematerial.objs)
                {
                    gameObject8.transform.GetComponent<MeshRenderer>().material = this.material[7];
                }
                break;
            case 9:
                foreach (GameObject gameObject9 in choosematerial.objs)
                {
                    gameObject9.transform.GetComponent<MeshRenderer>().material = this.material[8];
                }
                break;
            case 10:
                foreach (GameObject gameObject10 in choosematerial.objs)
                {
                    gameObject10.transform.GetComponent<MeshRenderer>().material = this.material[9];
                }
                break;
            case 11:
                foreach (GameObject gameObject11 in choosematerial.objs)
                {
                    gameObject11.transform.GetComponent<MeshRenderer>().material = this.material[10];
                }
                break;
        }
    }

    private void Update()
    {
    }

    
}
