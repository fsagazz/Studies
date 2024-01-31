from math import sqrt
def somatorioValoresFuncao(matriz=[[]], lista = [], a = bool()):
    somatorio = 0
    if matriz[1][1]!=1 and matriz[1][2]!=2 and a==False:
        for i in range (0,k):
            somatorio += matriz[i][2]
        return somatorio
    elif matriz[1][0]==0 and matriz[1][1] ==1 and matriz[1][2]==2:
        print("Limitantes e Frequências não declaradas, excutar o programa novamente e declara-las")
    elif a== True:
        for i in range (0,k):
            somatorio += matriz[i][2]*lista[i]
        return somatorio
        
def calculoXMedioFunc(valor):
    resultado = valor/2    
    return resultado

def calculoYiFunc(xmedios,xzeros, ampli):
    Yi = (xmedios-xzeros)/ampli
    return Yi

def desvioPadraoFunc(somyi2,somyi,amp,freq):
    div1 = somyi2/freq
    div2 = (somyi/freq)*(somyi/freq)
    soma = div1-div2
    if soma <0:
        print(f'A soma é negativa: {soma}')
    raiz = sqrt(soma)
    desvpad = raiz*amp
    return desvpad
    

k = int(input('Digite a quantidade de classes: '))
valores = [list(range(0, 3)) for i in range (k)]
print (valores)

for i in range (0,k):
    valores[i][0] = float(input(f"Digite aqui o limitante inferior da {i+1}ª classe: "))
    valores[i][1] = float(input(f"Digite aqui o limitante superior {i+1}ª da classe: "))
    valores[i][2] = float(input(f"Digite aqui a frequência da {i+1}ª classe: "))
        
print (valores)
#cálculo somatório de frequências:
somatorioFrequencia = somatorioValoresFuncao(valores, 0, False)

#definindo o intervalo com maior frequência: 
xzero = valores[0][2]
for i in range (1,k):
    if valores[i][2] >= valores[i-1][2]:
        xzero = (valores[i][0] + valores[i][1])/2
        amplitude = (valores[i][1] - valores[i][0])
print(amplitude)
#função que calcula os Xi(xmédios)
xmedios = list()
for i in range(0,k):
    xmedios.append(calculoXMedioFunc(valores[i][1]+valores[i][0]))
print (xmedios)

#função que calcula Yi
yi = list()
for i in range (0,k):
    yi.append(calculoYiFunc(xmedios[i],xzero, amplitude))

print (yi)
#calculo somatório de FiYi
somatorioFiYi = somatorioValoresFuncao(valores, yi, True)
print (somatorioFiYi)


#calculo somatório de FiYiYi
yi2 = list()
for i in range(0,k):
    yi2.append(yi[i]*yi[i])
somatorioFiYiYi = somatorioValoresFuncao(valores, yi2, True)
print(somatorioFiYiYi)

#calculo desvio padrão
desvpad = desvioPadraoFunc(somatorioFiYiYi,somatorioFiYi,amplitude,somatorioFrequencia)
print (desvpad)