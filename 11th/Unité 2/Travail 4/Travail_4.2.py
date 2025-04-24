# Fonction pour trouver le min et le max
def trouver_min_max(liste):
    min_val = liste[0]
    max_val = liste[0]
    
    for val in liste[1:]:
        if val < min_val:
            min_val = val
        if val > max_val:
            max_val = val
    
    return min_val, max_val

# Demander le nombre d'éléments
while True:
    try:
        n = int(input("Entrez le nombre d'éléments (minimum 10) : "))
        if n >= 10:
            break
        else:
            print("Veuillez entrer un nombre d'au moins 10.")
    except ValueError:
        print("Veuillez entrer un nombre entier valide.")

# Saisie des éléments
liste_valeurs = []
for i in range(n):
    while True:
        try:
            valeur = float(input(f"Entrez la valeur {i+1} : "))
            liste_valeurs.append(valeur)
            break
        except ValueError:
            print("Veuillez entrer un nombre valide.")

# Trouver le min et le max
min_val, max_val = trouver_min_max(liste_valeurs)

# Affichage des résultats
print("\nValeurs entrées :", liste_valeurs)
print("Valeur minimale :", min_val)
print("Valeur maximale :", max_val)
