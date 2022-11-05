def total_factorial(numero):
    try:
        if numero < 0:
            print("No existen factoriales para números negativos.")
        else:
            fact = 1
            while (numero > 1):
                fact *= numero
                numero -= 1
            print("El factorial de" + str(numero) + "es: " + str(fact))
            return fact
    except:
        print("Ha ingresado un número inválido")


# INGRESO DE CADENA
def input_numero():
    try:
        print("Problema 3")
        source = input('Ingrese un número: ')
        total_factorial(int(source))
        return source
    except:
        print("Ha ingresado un número inválido")



def main():
    cycle_main = True

    while cycle_main:
        input_numero()

        cycle = input('¿Desea ingresar otro número? (s/n): ')

        if cycle.lower() == "n":
            cycle_main = False


main()
