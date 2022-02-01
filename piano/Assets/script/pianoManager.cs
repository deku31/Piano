using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pianoManager : MonoBehaviour
{
    //[SerializeField] private Text btntext;

    //public int jumlahButton;
    //[SerializeField]private nadaScript pianoBtn;
    //[SerializeField] private Transform parent;

    public int tombolditekan;
    [SerializeField] private Image[] mask;
    [SerializeField] private audioManager btnsfx;

    private void Awake()
    {
        btnsfx = FindObjectOfType<audioManager>();
    }
    void Start()
    {
        foreach (var mask in mask)
        {
            mask.enabled = false;
        }
        //for (int i = 0; i < jumlahButton; i++)
        //{
        //    pianoBtn.NadaTombol = i + 1;
        //    txtbtnmanager();
        //    Instantiate(pianoBtn, parent);
        //}

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Mouse0))
        { 
            maskmethod();
            tombolmanager();
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                btnsfx.btnsound[tombolditekan - 1].PlayOneShot(btnsfx.clipbtn[tombolditekan - 1], 1f);
            }
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            mask[tombolditekan - 1].enabled = false;
            print("diam");
            tombolditekan = -1;
        }
    }
    public void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.A))
        {
            tombolditekan = 1;
            print("do");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            tombolditekan = 2;
            print("re");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            tombolditekan = 3;
            print("mi");
        }
        else if (Input.GetKey(KeyCode.F))
        {
            tombolditekan = 4;
            print("fa");
        }
        else if (Input.GetKey(KeyCode.G))
        {
            tombolditekan = 5;
            print("sol");
        }
        else if (Input.GetKey(KeyCode.H))
        {
            tombolditekan = 6;
            print("la");
        }
        else if (Input.GetKey(KeyCode.I))
        {
            tombolditekan = 7;
            print("si");
        }
    }
    public void maskmethod() {
        for (int i = 0; i < mask.Length; i++)
        {
            if (i==tombolditekan-1)
            {
                mask[tombolditekan-1].enabled = true;
            }
            else
            {
                mask[i].enabled = false;
            }
        }
    }
    public void tombolmanager()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit= Physics2D.Raycast(ray.origin, ray.direction);
        if (hit)
        {
            var selection = hit.transform;
            if (selection.CompareTag("do1"))
            {
                tombolditekan = 1;
                print("do");
            }
            else if (selection.CompareTag("re1"))
            {
                tombolditekan = 2;
                print("re");
            }
            else if (selection.CompareTag("mi1"))
            {
                tombolditekan = 3;
                print("mi");
            }
            else if (selection.CompareTag("fa1"))
            {
                tombolditekan = 4;
                print("fa");
            }
            else if (selection.CompareTag("sol1"))
            {
                tombolditekan = 5;
                print("sol");
            }
            else if (selection.CompareTag("la1"))
            {
                tombolditekan = 6;
                print("la");
            }
            else if (selection.CompareTag("si1"))
            {
                tombolditekan = 7;
                print("si");
            }
        }

        else
        {
            
        }
        //if (tombolditekan==1)
        //{
        //    Debug.Log("do");
        //}
        //else if (tombolditekan==2)
        //{
        //    Debug.Log("re");
        //}
        //else if (tombolditekan==3)
        //{
        //    Debug.Log("mi");
        //}
        //else
        //{
        //    Debug.Log(".");
        //}
    }
    //public void txtbtnmanager()
    //{
    //    if (pianoBtn.NadaTombol==1)
    //    {
    //        pianoBtn.btntext.text = "do";
    //    }
    //    else if (pianoBtn.NadaTombol == 2)
    //    {
    //        pianoBtn.btntext.text="re";
    //    }
    //    else if (pianoBtn.NadaTombol == 3)
    //    {
    //        pianoBtn.btntext.text = "mi";
    //    }


    //}
}
