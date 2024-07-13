def solution(numbers):
    answer = 0
    ndict = {
        'zero':'0',
        'one':'1',
        'two':'2',
        'three':'3',
        'four':'4',
        'five':'5',
        'six':'6',
        'seven':'7',
        'eight':'8',
        'nine':'9',
    }
    for k, v in ndict.items():
        numbers = numbers.replace(k,v)
    answer = int(numbers)
    return answer