x = int(input("Entrez le premier nombre : "))
y = int(input("Entrez le deuxième nombre : "))
z = int(input("Entrez le troisième nombre : "))

if x < y:
    x, y = y, x
if x < z:
    x, z = z, x
if y < z:
    y, z = z, y

print("Les nombres triés sont :", x, y, z)
