def solution(s):
    return True if sum(1 if c == 'p' else -1 if c == 'y' else 0 for c in s.lower())==0 else False