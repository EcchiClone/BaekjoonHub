using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
        int[] answer = new int[2];
        
        // 솔루션 : 주어진 내용을 정말 그대로 수행만 하면 될 것으로 보임
        // 0-1. NSWE의 튜플값 마련
        // 1. park를 한차례 순회하며(최대 2500회) S의 위치 찾기
        // 2. routes의 원소를 foreach순회
        // 2-1. 현재자리 기억
        // 2-2. for 반복문으로 0-1에서 마련한 튜플값만큼 이동 
        // 2-2-1. 이동 불가조건 만족 시 원래자리로 복귀
        // 3. 현재 자리(index) 반환
        
        // 0-1. NSWE의 튜플값 마련
        // 찾아보기. 제네릭으로 튜플값 사용하는 방법
        Dictionary<char,(int X,int Y)> going = new Dictionary<char, (int, int)>(){
            {'N',(0,-1)}, // (x, y) 순
            {'S',(0,1)},
            {'W',(-1,0)},
            {'E',(1,0)}
        };
        // 1. park를 한차례 순회하며(최대 2500회) S의 위치 찾기
        // 찾아보기. 튜플 변수 선언과 초기화
        // 찾아보기. (int, int) index와 같이 사용하는것은 불가능
        //          (int X, int Y) 로 수정
        //          이후 코드에서도 Item1 -> X, Item2 -> Y로 수정
        (int X, int Y) index = (-1,-1);
        for(int y=0;y<park.Length;y++)
            for(int x=0;x<park[0].Length;x++)
                if(park[y][x]=='S'){
                    index = (x,y);
                    x = park[0].Length;
                    y = park.Length;
                }
        // 2. routes의 원소를 foreach순회
        foreach(string directionInfo in routes){
            // 찾아보기: char로의 형변환
            char direction = char.Parse(directionInfo.Split(' ')[0]);
            int moveNum = int.Parse(directionInfo.Split(' ')[1]);
            // 2-1. 현재자리 기억
            // 찾아보기: 튜플값은 값 형식으로 다른 튜플에 할당하면 내용복사
            (int X, int Y) preIndex = index;
            // 2-2. for 반복문으로 0-1에서 마련한 튜플값만큼 이동 
            for(int i=0;i<moveNum;i++){
                // 찾아보기: 튜플은 아래와 같이 +=는 사용 할 수 없다.
                //index += going[direction];
                index = (index.X + going[direction].X, index.Y + going[direction].Y);
                // 2-2-1. 이동 불가조건 만족 시 원래자리로 복귀
                // 찾아보기: 튜플 요소에 접근
                if(
                    index.X<0 ||
                    index.Y<0 ||
                    index.X>= park[0].Length ||
                    index.Y>= park.Length
                ){
                    index = preIndex;
                    break;
                }
                else if(park[index.Item2][index.Item1] == 'X'){
                    index = preIndex;
                    break;
                }
                // 이동 확인 구문
                // Console.WriteLine($"{i}:({index.X}, {index.Y})");
            }
        }
        
        // 3. 현재 자리(index) 반환
        // 아래 구문은 왠지 잘 되지 않음.
        // (answer[0], answer[1]) = index;
        // 배열의 인덱스 위치에 직접 값을 할당하는 형태는 
        // 지원이 되는경우도 있고 안되는 경우도 있다는 듯
        answer[0] = index.Y;
        answer[1] = index.X;
        
        return answer;
    }
}