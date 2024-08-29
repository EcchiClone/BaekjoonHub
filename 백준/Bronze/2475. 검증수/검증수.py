datas = list(map(int, input().split()))
sum = 0
for data in datas:
    sum += data*data
checkNum = sum%10
print(checkNum)