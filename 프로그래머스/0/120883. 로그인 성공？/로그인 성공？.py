def solution(id_pw, db):
    answer = 'fail'
    
    for item in db:
        if item[0] == id_pw[0]:
            answer = 'wrong pw'
            if item[1] == id_pw[1]:
                return 'login'
        
    
    return answer