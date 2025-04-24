n = int(input("Entrez un entier positif : "))

diviseurs = [i for i in range(1, n + 1) if n % i == 0]
somme_diviseurs = sum(diviseurs)

print("Diviseurs =", ", ".join(map(str, diviseurs)))
print("Somme des diviseurs =", somme_diviseurs)
