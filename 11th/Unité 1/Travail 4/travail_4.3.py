import random
import string

# Générer un nombre entre 2 et 8 pour le nombre de majuscules
n = random.randint(2, 8)

# Générer n lettres majuscules
password = random.choices(string.ascii_uppercase, k=n)

# Ajouter un chiffre
password.append(random.choice(string.digits))

# Ajouter un symbole
password.append(random.choice(string.punctuation))

# Compléter avec des caractères aléatoires pour atteindre 10 caractères
while len(password) < 10:
    password.append(random.choice(string.ascii_letters + string.digits + string.punctuation))

# Mélanger le mot de passe
random.shuffle(password)

# Convertir la liste en chaîne
password = "".join(password)

print("Mot de passe généré :", password)
