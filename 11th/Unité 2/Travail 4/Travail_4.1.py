# Définition de la fonction
def notes_plus_que_moyenne(liste_notes):
    # Calcul de la moyenne arrondie en entier
    moyenne = sum(liste_notes) / len(liste_notes)
    moyenne = int(moyenne)  # Transformation en nombre entier
    
    # Extraction des notes supérieures à la moyenne
    notes_superieures = [note for note in liste_notes if note > moyenne]
    
    return moyenne, notes_superieures

# Demander le nombre de notes
while True:
    try:
        n = int(input("Entrez le nombre de notes : "))
        if n > 0:
            break
        else:
            print("Veuillez entrer un nombre positif.")
    except ValueError:
        print("Veuillez entrer un nombre entier valide.")

# Saisie des notes
liste_notes = []
for i in range(n):
    while True:
        try:
            note = float(input(f"Entrez la note {i+1} : "))
            if note >= 0:
                liste_notes.append(note)
                break
            else:
                print("Veuillez entrer une note positive.")
        except ValueError:
            print("Veuillez entrer un nombre valide.")

# Appel de la fonction
moyenne, liste_notes_sup = notes_plus_que_moyenne(liste_notes)

# Affichage des résultats
print("\nMoyenne :", round(moyenne, 2))
print("Notes supérieures à la moyenne :", *liste_notes_sup)

# Test avec la liste donnée
liste_test = [56, 67, 89, 76, 99, 90, 68, 80, 82, 81, 62]
moyenne_test, liste_test_sup = notes_plus_que_moyenne(liste_test)

print("\nTest avec la liste prédéfinie :")
print("Moyenne :", round(moyenne_test, 2))
print("Notes supérieures à la moyenne :", *liste_test_sup)
