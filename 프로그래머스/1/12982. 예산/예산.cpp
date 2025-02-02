#include <iostream>
#include <vector>
#include <algorithm> // sort 함수를 사용하기 위해 필요

using namespace std;

int solution(vector<int> d, int budget) {
    int answer = 0;
    int sum = 0;
    
    sort(d.begin(), d.end());
    
    for (int i = 0; i < d.size(); i++) {
        sum += d[i];
        if (sum <= budget) {
            answer++;
        } else {
            break;
        }
    }
    return answer;
}
