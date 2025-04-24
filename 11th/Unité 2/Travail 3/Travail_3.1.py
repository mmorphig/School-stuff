# Définition de la liste
liste = [17, 38, 10, 25, 72]

# Sauvegarder le dernier élément de la liste originale avant toute modification
dernier_element_original = liste[-1]

# 1. Afficher la liste initiale
print("------------ Liste initiale ------------")
print(liste)

# 2. Trier et afficher la liste
liste.sort()
print("\n------------ Liste triée ------------")
print(liste)

# 3. Ajouter l'élément 12 et afficher la liste
liste.append(12)
print("\n------------ Ajout d'un element ------------")
print(liste)

# 4. Renverser et afficher la liste
liste.reverse()
print("\n------------ Liste inversée ------------")
print(liste)

# 5. Afficher l’indice de l’élément 17
indice_17 = liste.index(17)
print("\n------------ Indice d'un element ------------")
print(indice_17)

# 6. Enlever l’élément 38 et afficher la liste
liste.remove(38)
print("\n------------ Suppression du 38 ------------")
print("La nouvelle liste :", *liste)

# 7. Afficher la sous-liste du 2e au 3e élément (indices 1 à 2)
print("\n------------ Les éléments du 2e au 3e ------------")
print("Le deuxième et le troisième :", liste[1:3])

# 8. Afficher la sous-liste du début au 2e élément (indices 0 à 1)
print("\n------------ Du début au deuxième ------------")
print("Début au 2e :", liste[:2])

# 9. Afficher la sous-liste du 3e élément à la fin
print("\n------------ Les éléments du 3e à la fin ------------")
print("Du troisième à la fin :", liste[2:])

# 10. Afficher la liste inversée encore une fois
print("\n------------ La liste inversée ------------")
print("Liste inversée :", liste[::-1])

# 11. Afficher le dernier élément de la liste originale (avant modification)
print("\n------------ Le dernier élément de la liste originale ------------")
print("Dernier élément", dernier_element_original)
