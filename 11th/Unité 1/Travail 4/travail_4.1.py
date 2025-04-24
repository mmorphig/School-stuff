a = int(input("Donnez la première valeur a : "))
b = int(input("Donnez la deuxième valeur b : "))

# Déterminer p (petit) et g (grand)
if a < b:
    p = a
    g = b
else:
    p = b
    g = a

# Afficher les valeurs de p à g
print(f"Les valeurs de {p} à {g} sont :")
for i in range(p, g + 1):
    print(i, end=" ")
print()  # Saut de ligne

# Afficher les valeurs impaires de g à 0
print(f"Les valeurs impaires de {g} à 0 sont :")
for i in range(g, -1, -1):
    if i % 2 != 0:
        print(i, end=" ")
print()  # Saut de ligne
