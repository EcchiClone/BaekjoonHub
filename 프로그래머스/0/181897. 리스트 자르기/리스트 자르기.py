def solution(n, slicer, num_list):
    answer = []
    if(n==1):
        answer = num_list[:slicer[1]+1]
    if(n==2):
        answer = num_list[slicer[0]:]
    if(n==3):
        answer = num_list[slicer[0]:slicer[1]+1]
    if(n==4):
        answer = num_list[slicer[0]:slicer[1]+1:slicer[2]]
    return answer