def solution(today, terms, privacies):
    
    answer = []
    
    today = [int(i) for i in today.split('.')]
    
    terms_dict = {key: int(value) for key, value in (item.split() for item in terms)}
    
    for data_n in range(len(privacies)):
        
        data = privacies[data_n]
        term_type = data.split()[1]
        
        date = [int(i) for i in data.split()[0].split('.')]
        date[1] += terms_dict[term_type]
        
        today_value = today[0]*28*12 + today[1]*28 + today[2]
        date_value = date[0]*28*12 + date[1]*28 + date[2]
        
        if(today_value >= date_value):
            answer.append(data_n+1)
        
    return answer