from itertools import permutations
from math import sqrt

def solution(numbers):
    
    answer = 0
    
    # 검증된 소수 집합
    prime_set = set()
    
    # ['1', '7'] 과 같이 리스트 형태로 변환
    numbers_list = [i for i in numbers]
    
    # 가능한 모든 순열 탐색
    for i in range(1, len(numbers_list)+1): # 순열의 길이는 1부터 최대길이까지
        
        # 각 길이에 맞는 모든 순열의 경우를 리스트 형태로 저장. 라이브러리 활용함.
        # i == 1 일 경우, [ (1), (7) ]
        # i == 2 일 경우, [ (1,7), (7,1) ]
        per_list = list(permutations(numbers_list, i))
        
        # 각 원소 선택해서 문자열로 만들고, 소수인지 검증
        for element in per_list:
            
            number_str = ''.join(element)
            
            # 첫 글자가 0이 아닌 경우만 검증 작업
            if(number_str[0] != '0'):
                
                number = int(number_str)
                
                # 소수 검증 True일 경우, prime_set 집합에 해당 number 추가
                if(is_prime(number)):
                    prime_set.add(number)
    
    # prime_set 집합의 원소의 갯수를 반환
    answer = len(prime_set)
    return answer

# 소수 판별 함수
def is_prime(number):
    
    if number==1:
        return False
    
    for i in range(2, int(sqrt(number))+1):
        if number%i==0:
            return False
    
    return True