def solution(spell, dic):
    answer = 2
    
    for word in dic:
        if len(word)==len(spell):
            for c in spell:
                if c not in word:
                    break
                if c==spell[-1]:
                    answer = 1
                    return answer
    
    return answer