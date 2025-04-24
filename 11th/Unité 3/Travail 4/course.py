import turtle
import random

sc = turtle.Screen()
sc.setup(1000, 400)
sc.bgcolor('pink')

def carre(cote, couleur, position, t):
    x, y = position
    t.goto(x, y)
    t.color(couleur)
    t.begin_fill()
    t.goto(x + cote, y)
    t.goto(x + cote, y + cote)
    t.goto(x, y + cote)
    t.goto(x, y)
    t.end_fill()

def isintersect(t1, t2):
    return t2.xcor() < t1.xcor() + 5

# Création des tortues
joueur1 = turtle.Turtle()
joueur2 = turtle.Turtle()
carrebleu = turtle.Turtle()
carrerouge = turtle.Turtle()
texte = turtle.Turtle()

# Configuration des joueurs
joueur1.shape('triangle')
joueur2.shape('square')
joueur1.color('blue')
joueur2.color('red')
joueur1.penup()
joueur2.penup()
joueur1.speed()
joueur2.speed()
joueur1.goto(-400, 100)
joueur2.goto(-400, -100)

# Placement des carrés de fin de course
carrebleu.penup()
carrerouge.penup()
carrebleu.speed(0)
carrerouge.speed(0)
carrebleu.hideturtle()
carrerouge.hideturtle()
carre(80, 'blue', (200, 60), carrebleu)
carre(80, 'red', (200, -140), carrerouge)

# Placement du texte
texte.penup()
texte.speed(0)
texte.goto(-200,175)
texte.hideturtle()

texte_actuel = ''
while not (isintersect(joueur1, carrebleu) or isintersect(joueur2, carrerouge)):
    texte_ancien = texte_actuel
    tour = random.choice([1, 2])
    vitesse = random.choice(range(1, 5))
    if tour == 1:
        joueur1.forward(3 * vitesse)
    else:
        joueur2.forward(3 * vitesse)
    
    if joueur1.xcor() > joueur2.xcor():
        texte_actuel = 'Joueur bleu dépasse'
    elif joueur1.xcor() < joueur2.xcor():
        texte_actuel = 'Joueur rouge dépasse'
    else:
        actuel = 'Joueurs ont la même position'
    
    if texte_actuel != texte_ancien:
        texte.clear()
        texte.write(texte_actuel, align='center', font=('Arial', 14, 'normal'))

texte.goto(-190, 0)
if joueur1.xcor() > joueur2.xcor():
    texte.write('Joueur bleu a gagné !', align='center', font=('Arial', 16, 'bold'))
else:
    texte.write('Joueur rouge a gagné !', align='center', font=('Arial', 16, 'bold'))

turtle.done()
