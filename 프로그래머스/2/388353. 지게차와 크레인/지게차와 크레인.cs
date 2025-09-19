using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    
    struct Vector2{
        public int x;
        public int y;
        public Vector2(int x, int y){
            this.x = x;
            this.y = y;
        }
    }
    
    char[,] grid;
    bool[,] isOuter;
    int height;
    int width;
    
    public int solution(string[] storage, string[] requests) {
        int answer = 0;
        
        height = storage.GetLength(0);
        width = storage[0].Length;
        
        grid = new char[height,width];
        for(int y=0;y<height;y++)
            for(int x=0;x<width;x++)
                grid[y,x] = storage[y][x];
        
        // 겉면 여부
        isOuter = new bool[height, width];
        
        for(int i=0;i<width;i++) { isOuter[0,i]=true; isOuter[height-1,i]=true; }
        for(int i=0;i<height;i++) { isOuter[i,0]=true; isOuter[i,width-1]=true; }
        
        for(int i=0;i<requests.Length;i++){
            
            string request = requests[i];
            char symbol = request[0]; // 고를 문자
            bool isCrain = (request.Length==2);
            
            List<Vector2> checker= new List<Vector2>();
            
            for(int y=0;y<height;y++){
                for(int x=0;x<width;x++){
                    if(grid[y,x]==symbol && (isOuter[y,x] || isCrain)){
                        grid[y,x] = '-';
                        checker.Add(new Vector2(x,y));
                    }
                }
            }
            foreach(Vector2 element in checker){
                DFSOuterCheck(element.x, element.y);
            }
            
            // for(int y=0;y<height;y++){
            //     for(int x=0;x<width;x++)
            //         Console.Write(grid[y,x]);
            //     Console.Write("\n");
            // }
            // for(int y=0;y<height;y++){
            //     for(int x=0;x<width;x++)
            //         Console.Write(isOuter[y,x]?"O":"X");
            //     Console.Write("\n");
            // }
            // Console.Write("\n");
            
        }
        
        for(int y=0;y<height;y++)
            for(int x=0;x<width;x++)
                if(grid[y,x]!='-') answer++;
        
        return answer;
    }
    
    public void DFSOuterCheck(int x, int y){
        if(!isOuter[y,x]) return;
        // isOuter[y,x] = true;
        if(0<x){ // 왼쪽으로 확장
            if(isOuter[y,x-1] == false && grid[y,x-1]=='-'){
            isOuter[y,x-1] = true;
                DFSOuterCheck(x-1,y);
            }
            isOuter[y,x-1] = true;
        }
        if(width-1>x){ // 오른쪽으로 확장
            if(isOuter[y,x+1] == false && grid[y,x+1]=='-'){
            isOuter[y,x+1] = true;
                DFSOuterCheck(x+1,y);
            }
            isOuter[y,x+1] = true;
        }
        if(0<y){ // 위쪽으로 확장
            if(isOuter[y-1,x] == false && grid[y-1,x]=='-'){
            isOuter[y-1,x] = true;
                DFSOuterCheck(x,y-1);
            }
            isOuter[y-1,x] = true;
        }
        if(height-1>y){ // 아래로 확장
            if(isOuter[y+1,x] == false && grid[y+1,x]=='-'){
            isOuter[y+1,x] = true;
                DFSOuterCheck(x,y+1);
            }
            isOuter[y+1,x] = true;
        }
    }
    
}