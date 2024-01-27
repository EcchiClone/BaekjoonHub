using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[4];
        
        int width = wallpaper[0].Length;
        int height = wallpaper.Length;
        
        // 솔루션:상하좌우 네 방향에서 각각 가장 가까운 '#'을 찾기
        // 상단
        for(int y=0;y<height;y++){
            for(int x=0;x<width;x++){
                if(wallpaper[y][x]=='#'){
                    answer[0]=y;
                    y=height;
                    break;
                }
            }
        }
        // 좌변
        for(int x=0;x<width;x++){
            for(int y=0;y<height;y++){
                if(wallpaper[y][x]=='#'){
                    answer[1]=x;
                    x=width;
                    break;
                }
            }
        }
        // 하단
        for(int y=height-1;y>=0;y--){
            for(int x=width-1;x>=0;x--){
                if(wallpaper[y][x]=='#'){
                    answer[2]=y+1;
                    y=-1;
                    break;
                }
            }
        }
        // 우측
        for(int x=width-1;x>=0;x--){
            for(int y=height-1;y>=0;y--){
                if(wallpaper[y][x]=='#'){
                    answer[3]=x+1;
                    x=-1;
                    break;
                }
            }
        }
        
        return answer;
    }
}