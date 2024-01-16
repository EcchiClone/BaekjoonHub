using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        
        List<string> card1List = cards1.ToList();
        List<string> card2List = cards2.ToList();
        List<string> goalList = goal.ToList();
        
        while(goalList.Count>0){
            if(goalList[0]== (card1List.Count!=0 ? card1List[0] : "") ){
                card1List.RemoveAt(0);
                goalList.RemoveAt(0);
            }
            else if(goalList[0]== (card2List.Count!=0 ? card2List[0] : "") ){
                card2List.RemoveAt(0);
                goalList.RemoveAt(0);
            }
            else return "No";
        }
        
        
        
        return "Yes";
    }
}