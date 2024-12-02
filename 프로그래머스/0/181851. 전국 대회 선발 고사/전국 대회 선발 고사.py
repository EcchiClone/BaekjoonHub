def solution(rank, attendance):
    answer = 0
    relist = [rank[i] for i in range(len(rank)) if attendance[i] == True]
    relist.sort()
    
    print(relist)
    answer += rank.index(relist[0]) * 10000
    answer += rank.index(relist[1]) * 100
    answer += rank.index(relist[2])
    return answer