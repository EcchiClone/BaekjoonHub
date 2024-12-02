str = input()
newStr = ''
for c in str:
    if(c==c.upper()):
        newStr += c.lower()
    else:
        newStr += c.upper()
print(newStr)