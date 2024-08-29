N = int(input())

if(N==4 or N==7):
    print(-1)

elif(N%5==0): print(int(N/5))
elif(N%5==1): print(int(N/5)+1)
elif(N%5==2): print(int(N/5)+2)
elif(N%5==3): print(int(N/5)+1)
elif(N%5==4): print(int(N/5)+2)