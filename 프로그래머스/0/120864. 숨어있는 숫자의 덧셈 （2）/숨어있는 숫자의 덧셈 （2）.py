def solution(my_string):
    answer = 0
    edited_string = my_string[:]
    for i in range(len(my_string)):
        if(my_string[i].isdigit()==False):
            # print("Replace")
            edited_string = edited_string.replace(my_string[i],' ')
    answer = sum([int(n) for n in edited_string.split()])
    return answer