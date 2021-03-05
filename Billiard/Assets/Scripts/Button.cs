using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        lefttime = maxhittime;
        leftview.GetComponent<Text>().text = System.Convert.ToString(lefttime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if (lefttime == 0) return;
        this.gameObject.GetComponent<Button>().enabled = false;
        StartCoroutine(Countdowm());
        lefttime--;
        leftview.GetComponent<Text>().text = System.Convert.ToString(lefttime);
        double angledegree = System.Math.PI * double.Parse(angle.GetComponent<InputField>().text) /180.0 ;
        gameball.GetComponent<Rigidbody>().velocity = new Vector3(-float.Parse(strength.GetComponent<InputField>().text) * (float)System.Math.Cos(angledegree), 0, -float.Parse(strength.GetComponent<InputField>().text) * (float)System.Math.Sin(angledegree));
    }
    IEnumerator Countdowm()
    {
        yield return new WaitForSeconds(3.0f);
        this.gameObject.GetComponent<Button>().enabled = true;
        if (lefttime == 0)
        {
            if (GameObject.FindGameObjectsWithTag("redball").Length == 0 && GameObject.FindGameObjectsWithTag("blueball").Length == 0 && GameObject.FindGameObjectsWithTag("yellowball").Length == 0 && GameObject.FindGameObjectsWithTag("oringeball").Length == 0) leftview.GetComponent<Text>().text = "You Win!";
            else leftview.GetComponent<Text>().text = "You Lose!";
        }
    }
    public GameObject gameball;
    public GameObject angle;
    public GameObject strength;
    public GameObject leftview;
    public int maxhittime;
    private int lefttime;
}
