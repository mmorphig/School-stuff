# Demander à l'utilisateur un nombre et la taille de la table
nombre = int(input("Donner le nombre pour afficher sa table : "))
taille = int(input("Donner la taille de la table : "))

# Afficher la table de multiplication
for i in range(taille + 1):
    print(str(i) + " x " + str(nombre) + " = " + str(i * nombre))
