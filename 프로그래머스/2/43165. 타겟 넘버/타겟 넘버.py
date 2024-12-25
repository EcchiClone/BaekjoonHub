from itertools import combinations

def solution(numbers, target):
    answer = 0
    newTargetNumber = (sum(numbers) - target) / 2

    # 모든 조합 탐색
    for r in range(1, len(numbers) + 1):
        for combination in combinations(numbers, r):
            if sum(combination) == newTargetNumber:
                answer += 1
                
    return answer