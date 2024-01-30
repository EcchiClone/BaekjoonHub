using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        string[] answer = new string[] {};
        
        // 솔루션 1
        // 1. 선수이름으로 등수를, 등수로부터 선수이름을 아는 사전형 두개를 준비
        // 2. 선수 이름이 불리면
        // 2-1. 해당 선수의 등수 확인 (ex. 5등)
        // 2-2. 5등과 4등의 value값을 서로 바꾸며 이름 확인
        // 2-3. 해당 이름을 가진 두 선수의 등수를 바꾼다
        // 3. 모든 호명이 끝나면, 1등부터 answer에 입력
        
        // 솔루션 2
        // 다른 솔루션으로 생각해 볼 수 있는 건, ('5등이름','4등이름') 과 같이
        // ('선수','앞선선수')의 key,value값을 가지는 사전형을 사용해 볼 수도 있을 듯.
        // 이렇게 하면, 공간복잡도를 줄일 수 있다.
        // => 파기. 실제 해보니 ('앞선수','선수','뒷선수')의 리스트형이 필요한데, 공간복잡도도 낮지 않고 복잡함.
        
        // 1. 선수이름으로 등수를, 등수로부터 선수이름을 아는 사전형 두개를 준비
        Dictionary<string,int> playerToNum = new Dictionary<string,int>();
        Dictionary<int,string> numToPlayer = new Dictionary<int,string>();
        for(int i=0;i<players.Length;i++){
            playerToNum.Add(players[i],i);
            numToPlayer.Add(i,players[i]);
        }
        
        // 2. 선수 이름 호명
        foreach(string call in callings){
            
            // 2-1. 해당 선수의 등수 확인
            int num = playerToNum[call];
            
            // 2-2. 해당 등수 선수와 앞등수 선수의 value값을 서로 바꾸며 이름 확인
            string prePlayer = numToPlayer[num-1];
            numToPlayer[num] = prePlayer;
            numToPlayer[num-1] = call;
            
            // 2-3. 해당 이름을 가진 두 선수의 등수를 바꾼다
            playerToNum[prePlayer] = num;
            playerToNum[call] = num-1;
        }
        
        // 3. 모든 호명이 끝나면, 1등부터 answer에 입력
        // 검색 : Linq를 이용한 한줄 표현
        answer = numToPlayer.OrderBy(kvp => kvp.Key).Select(kvp => kvp.Value).ToArray();
        
        return answer;
    }
}