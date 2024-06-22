def solution(arr, intervals):
    answer = []
    answer = arr[intervals[0][0]:intervals[0][1]+1] + arr[intervals[1][0]:intervals[1][1]+1]
    return answer