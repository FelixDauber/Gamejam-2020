using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class EvolutionMenu : MonoBehaviour
{
    public static EvolutionMenu evolutionMenu;
    [SerializeField] private GameObject[] evolutionSlots;
    [SerializeField] private GameObject[] evolutions;
    [SerializeField] private GameObject[] evolutionButtons;
    [SerializeField] private GameObject player;
    [SerializeField] private string playerName;
    [SerializeField] private GameObject displayDNA;
    [SerializeField] private int currentSlot;
    private int curretnEvolCheck;

    public int dNA;
    public int DNA
    {
        get => dNA; 
        set
        {
            dNA = value;
            UpdateDNA();
        }
    }

    private void Start(){
        evolutionMenu = this;
        player = GameObject.Find(playerName);
        evolutionSlots[0] = GameObject.Find("PlayerEvol1");
        evolutionSlots[1] = GameObject.Find("PlayerEvol2");
        evolutionSlots[2] = GameObject.Find("PlayerEvol3");
        evolutionSlots[3] = GameObject.Find("PlayerEvol4");
        evolutionSlots[4] = GameObject.Find("PlayerEvol5");
        UpdateDNA();
    }
    public void OpenMenu(){
        //make the menu pop up
    }

    public void UpdateDNA(){
        displayDNA.GetComponent<Text>().text = DNA.ToString();
    }

    public void SellAll(){
        curretnEvolCheck = 0;
        foreach (var evol in evolutionSlots)
        {
            DNA += evolutionSlots[curretnEvolCheck].GetComponentInChildren<EvolutionInfo>().Cost; 
            evolutionSlots[curretnEvolCheck].GetComponentInChildren<EvolutionInfo>().DestroySelf();
            curretnEvolCheck ++;
        }
        UpdateDNA();
    }
    public void WhichEvolveSlot(int whichSlot){
        currentSlot = whichSlot;
    }
    public void ButtonPress(int whichButton){
        ApplyEvolution(evolutions[whichButton], evolutionSlots[currentSlot]);
    }
    public void ApplyEvolution(GameObject evolution, GameObject evolveSlot){
        //make if statement here that checks the cost for the evolution compared to how much DNA you have. 
        if(DNA - evolution.GetComponent<EvolutionInfo>().Cost >= 0 && evolveSlot.transform.childCount < 1 ){
            Instantiate(evolution, evolveSlot.transform.position, evolveSlot.transform.rotation, evolveSlot.transform);
            DNA -= evolution.GetComponent<EvolutionInfo>().Cost;
            UpdateDNA();
        }
    }
}
