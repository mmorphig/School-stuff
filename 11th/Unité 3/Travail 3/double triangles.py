import turtle
import math

largeur_screen = 1200

sc = turtle.Screen()
sc.setup(largeur_screen, 400)
sc.bgcolor("white")

t = turtle.Turtle()
t.speed(0)
t.width(2)
t.hideturtle()

def triangle(taille, couleur, position, angle=0):
    x, y = position
    t.goto(x, y)
    t.setheading(angle)
    t.color(couleur)
    t.begin_fill()

    # Calcul des sommets avec rotation
    x1, y1 = x + taille, y
    x2, y2 = x + taille / 2, y + (taille * (3**0.5)) / 2

    # Appliquer la rotation aux points
    def rotate(px, py, cx, cy, a):
        rad = math.radians(a)
        cos_a, sin_a = math.cos(rad), math.sin(rad)
        return (
            cx + (px - cx) * cos_a - (py - cy) * sin_a,
            cy + (px - cx) * sin_a + (py - cy) * cos_a
        )

    x1, y1 = rotate(x1, y1, x, y, angle)
    x2, y2 = rotate(x2, y2, x, y, angle)

    # Tracé du triangle avec `goto`
    t.goto(x1, y1)
    t.goto(x2, y2)
    t.goto(x, y)

    t.end_fill()

def dessiner_bloc(cote, couleur_sup, couleur_cercle, couleur_inf, position):
    x, y = position
    
    # Dessiner le triangle supérieur
    triangle(cote, couleur_sup, (x, y))
    
    # Placer et dessiner le cercle au centre
    centre_x = x + cote / 2
    t.goto(centre_x, y) # La variable y est déja le centre, pas besoin d'une nouvelle variable
    t.color(couleur_cercle)
    t.begin_fill()
    t.circle(cote / 3)
    t.end_fill()
    
    # Dessiner le triangle inférieur
    triangle(cote, couleur_inf, (x+cote, y), 180)

# Paramètres initiaux
cote = 40
x, y = -largeur_screen / 2 + 25, 0 # Calcul pour essayer de centrer les triangles dans la fenètre, le +25 les bouge plus au centre et est parfait à 1000

for _ in range(8):
    t.up() # Cette code utilise seulement des fill, penup pour ne pas avoir des lignes partout
    dessiner_bloc(cote, 'fuchsia', 'pink', 'cyan', (x, y))
    x += cote + 10  # Augmenter la taille et espacer
    cote += 20  # Augmenter la taille du triangle

turtle.done()
