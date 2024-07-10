def solution(myStr):
    answer = []
    answer = myStr[:].replace('a',' ').replace('b', ' ').replace('c', ' ').split()
    if(answer == []):
        answer.append("EMPTY")
    
    return answer