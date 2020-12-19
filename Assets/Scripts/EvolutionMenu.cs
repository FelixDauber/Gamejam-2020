using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvolutionMenu : MonoBehaviour
{
    [SerializeField] private GameObject[] evolutionSlots;

    [SerializeField] private GameObject[] evolutions;
    [SerializeField] private GameObject player;
    [SerializeField] private string playerName;
    public int DNA;

    private void Start(){
        player = GameObject.Find(playerName);
        evolutionSlots[0] = GameObject.Find("PlayerEvol1");
        evolutionSlots[1] = GameObject.Find("PlayerEvol2");
        evolutionSlots[2] = GameObject.Find("PlayerEvol3");
        evolutionSlots[3] = GameObject.Find("PlayerEvol4");
        evolutionSlots[4] = GameObject.Find("PlayerEvol5");
    }
    public void OpenMenu(){

    }
    public void ApplyEvolution(GameObject evolution, GameObject evolveSlot){
        //make if statement here that checks the cost for the evolution compared to how much DNA you have. 
        if(DNA - evolution.GetComponent<EvolutionInfo>().Cost >= 0){
            Instantiate(evolution, evolveSlot.transform, evolveSlot);
            DNA -= evolution.GetComponent<EvolutionInfo>().Cost;
        }
    }
}
