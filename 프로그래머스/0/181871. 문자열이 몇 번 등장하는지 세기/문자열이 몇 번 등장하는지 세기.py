def solution(myString, pat):
    answer = 0
    for i in range(len(myString)-len(pat)+1):
        # print(myString[i:i+len(pat)])
        # print(pat)
        if(myString[i:i+len(pat)]==pat):
            answer += 1
    return answer