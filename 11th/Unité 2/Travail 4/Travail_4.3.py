# Fonction pour filtrer les chaînes
def filtrer_chaines(liste_chaines):
    return [chaine for chaine in liste_chaines if len(chaine) >= 2 and chaine[0] == chaine[-1]]

# Liste de test
liste_test = ['abc', 'xyz', 'aba', '1221']

# Appel de la fonction
resultat = filtrer_chaines(liste_test)

# Affichage des résultats
print("Chaînes filtrées :", resultat)
