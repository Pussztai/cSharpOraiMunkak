list = [7,8,7,9,3,2,4,3,3,6]

osszeg = 0
for x in range(len(list),-1):
    for y in range(x + 1,len(list)):
        if list[y] > list[y-1]:
            osszeg += 1


print(osszeg)