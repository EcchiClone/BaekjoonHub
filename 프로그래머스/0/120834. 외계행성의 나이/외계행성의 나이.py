def solution(age):
    answer = ''
    for c in str(age):
        print(c)
        answer += chr(int(c)+97)
    return answer