def solution(bin1, bin2):
    answer = bin(int(bin1,2) + int(bin2,2)).replace('0b','')
    return answer