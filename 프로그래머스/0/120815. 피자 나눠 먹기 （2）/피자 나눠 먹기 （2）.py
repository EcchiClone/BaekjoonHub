
def solution(n):
    answer = 0
    answer = lcm(n,6)/6
    return answer

def lcm(n,m):
    return n // gcd(n,m) * m

def gcd(n,m):
    if m==0:
        return n
    else:
        return gcd(m, n%m)