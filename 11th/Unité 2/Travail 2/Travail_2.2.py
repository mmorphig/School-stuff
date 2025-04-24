# Vérification de l'entrée de n
while True:
    try:
        n = int(input("Entrez le nombre d'éléments de la liste (nombre positif) : "))
        if n > 0:
            break
        else:
            print("Veuillez entrer un nombre positif.")
    except ValueError:
        print("Veuillez entrer un nombre valide.")

# Initialisation de la liste
L = []

# Saisie des éléments de la liste
for i in range(n):
    while True:
        try:
            nombre = float(input(f"Entrez l'élément {i+1} : "))
            L.append(nombre)
            break
        except ValueError:
            print("Veuillez entrer un nombre valide.")

# Saisie du multiplicateur p
while True:
    try:
        p = int(input("Entrez un entier p pour multiplier la liste : "))
        break
    except ValueError:
        print("Veuillez entrer un nombre entier valide.")

# Affichage et multiplication
nouvelle_liste = []
print("\nMultiplication des éléments par", p, ":")
for nombre in L:
    produit = nombre * p
    print(f"{nombre} × {p} = {produit}")
    nouvelle_liste.append(produit)

# Affichage de la nouvelle liste
print("\nNouvelle liste après multiplication :", nouvelle_liste)
