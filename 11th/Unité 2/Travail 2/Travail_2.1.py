# Initialisation de la liste
L = []

while True:
    try:
        # Demander à l'utilisateur un nombre
        nombre = float(input("Entrez un nombre (positif ou négatif) : "))
        L.append(nombre)
        
        # Demander s'il veut continuer
        continuer = input("Voulez-vous continuer ? (O/N) : ").strip().upper()
        if continuer == 'N':
            break
    except ValueError:
        print("Veuillez entrer un nombre valide.")

# Calcul de la longueur de la liste sans `len()`
longueur = 0
for _ in L:
    longueur += 1

# Affichage des résultats
print("\nListe des nombres entrés :", L, "\n")
print("Longueur de la liste :", longueur)
