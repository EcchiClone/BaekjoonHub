def solution(num_list):
    answer = 0
    count = 0
    for n in num_list:
        while(n!=1):
            if(n%2==0):
                n /= 2
            else:
                n = (n-1)/2
            count += 1
    answer = count
    return answer