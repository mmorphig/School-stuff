chaine1 = input("Entrez la première chaîne : ")
chaine2 = input("Entrez la deuxième chaîne : ")

if len(chaine1) > len(chaine2):
    print("La plus grande chaîne est :", chaine1)
elif len(chaine2) > len(chaine1):
    print("La plus grande chaîne est :", chaine2)
else:
    print("Les deux chaînes sont de même longueur.")
