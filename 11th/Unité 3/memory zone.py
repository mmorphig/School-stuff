# imports important: math, turtle, random

# Initialiser la fenêtre
sc = turtle.Screen()
sc.setup(width=1000, height=1000)
sc.bgcolor("white")
sc.tracer(0, 0)

for i in range(1, 7):
    sc.addshape("./b" + str(i) + ".png")
    images.append("./b" + str(i) + ".png")

# Déclaration de tortue
t = turtle.Turtle()
t.hideturtle()
t.penup()
t.shape(images[0])
t.speed()
t.goto(0, 0)
t.color("black")

def carre(taille, couleur, position):
    x, y = position
    t.goto(x, y)
    t.color(couleur)
    t.begin_fill()

    # Dessin rapide du carré
    t.goto(x + taille, y)
    t.goto(x + taille, y + taille)
    t.goto(x, y + taille)
    t.goto(x, y)

    t.end_fill()

def rectangle(hauteur, largeur, couleur, position):
    x, y = position
    t.goto(x, y)
    t.color(couleur)
    t.begin_fill()

    # Dessin rapide du rectangle
    t.goto(x + largeur, y)
    t.goto(x + largeur, y + 2 * hauteur)
    t.goto(x, y + 2 * hauteur)
    t.goto(x, y)

    t.end_fill()


def cercle(taille, couleur, position, angle=360):
    x, y = position
    t.goto(x, y - taille / 2)
    t.down()
    t.color(couleur)
    t.begin_fill()

    # Dessin rapide du cercle
    t.circle(taille / 2, angle)

    t.end_fill()
    t.up()

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
