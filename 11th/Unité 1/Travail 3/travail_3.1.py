n = int(input("Entrez le nombre de rangées : "))

for i in range(n):
    for j in range(i + 1):  # Boucle pour afficher les étoiles
        print("*", end=" ")
    print()  # Saut de ligne après chaque rangée
