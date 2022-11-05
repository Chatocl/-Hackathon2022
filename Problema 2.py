# CONTADOR DE VOCALES DENTRO DE LA CADENA INGRESADA
def total_vocales(frase):
    contador = 0
    for letra in frase:
        if letra.lower() in "aeiou":
            contador += 1

    print(f"En la cadena '{frase}' hay {contador} vocales")
    return contador

# INGRESO DE CADENA
def input_texto():
    print("Problema 2")
    source = input('Ingrese una cadena para contar sus vocales: ')
    total_vocales(source)
    return source


def main():
    cycle_main = True

    while cycle_main:
        input_texto()

        cycle = input('¿Desea ingresar otra palabra? (s/n): ')

        if cycle.lower() == "n":
            cycle_main = False


main()
