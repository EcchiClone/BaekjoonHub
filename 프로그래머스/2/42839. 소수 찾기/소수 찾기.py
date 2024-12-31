from itertools import permutations
from math import sqrt

def solution(numbers):
    answer = 0
    
    prime_set = set()
    
    numbers_list = [i for i in numbers]
    for i in range(1, len(numbers_list)+1):
        per_list = list(permutations(numbers_list, i))
        for element in per_list:
            number_str = ''.join(element)
            if(number_str[0] != '0'):
                number = int(number_str)
                if(is_prime(number)):
                    prime_set.add(number)
                    print(number)
    answer = len(prime_set)
    return answer

def is_prime(number):
    
    if number==1:
        return False
    
    for i in range(2, int(sqrt(number))+1):
        if number%i==0:
            return False
    
    return True