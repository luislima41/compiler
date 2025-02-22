# Trabalho Final de Compiladores

## Introdução

Bem-vindo ao README do projeto final da matéria de Compiladores!

Neste documento, você encontrará informações essenciais sobre o funcionamento e o propósito do interpretador que desenvolvemos utilizando a linguagem C#.

Este compilador é composto por diversos componentes, como o analisador léxico, analisador sintático e pré-processador.
Cada um desses componentes desempenha um papel crucial no processo de interpretação do código fonte, garantindo que tudo funcione perfeitamente.

## Requisitos

Para compilar e executar o interpretador localmente é necessário ter instalado:

- [SDK do C#](https://dotnet.microsoft.com/pt-br/download/dotnet/thank-you/sdk-9.0.102-windows-x64-installer)
- [Antlr4](https://www.antlr.org/download.html)

### Executar o Projeto

Siga os seguintes passos para executar:

- Clone este repositório
- Abra um terminal e navegue até o diretório raiz do projeto (Onde `BasicC.g4` está localizado).
- Digite o comando `dotnet run` no terminal.

## Exemplos

## Arquitetura do interpretador

```C
#include <stdio.h>

int main() {
    printf("Hello World");
    return 0;
}
```

## Declaração e Inicialização de Variáveis

```C
#include <stdio.h>

int main() {
    int a = 10;
    double b = 20.5;
    str c = "Hello";
    bool d = true;

    printf("a = %d", a);
    printf("b = %f", b);
    printf("c = %s", c);
    printf("d = %d", d);
    return 0;
}
```

## Estruturas de Controle

```C
#include <stdio.h>

int main() {
    int a = 20;
    int b = 20;
    if (a < b) {
        printf("a is less than b");
    } else {
        printf("a is greater or equal than b");
    }
    return 0;
}
```

```C
#include <stdio.h>

int main() {
    for (int i = 0; i < 10; i = i + 1) {
        printf(i);
    }
    return 0;
}
```

```C
#include <stdio.h>

int main() {
    int a = 0;
    while (a < 10) {
        printf("a = %d", a);
        a = a + 1;
    }
    return 0;
}
```

```C
#include <stdio.h>

int main() {
    int a = 0;
    do {
        printf("a = %d", a);
        a = a + 1;
    } while (a < 0);
    return 0;
}
```

## Entrada e Saída

```C
#include <stdio.h>

int main() {
    int a = 0;

    printf("Hello World");
    printf(a);

    scanf("%d", &b);
    printf(b);

    str c = "";
    gets(c);
    puts(c);

    return 0;
}
```

## Operadores

```C
#include <stdio.h>

int main() {
    int a = 10;
    int b = 5;

    printf(a + b);
    printf(a - b);
    printf(a * b);
    printf(a / b);
    printf(a % b);
    return 0;
}
```

```C
#include <stdio.h>

int main() {
    int a = 10;
    int b = 10;

    if (a == b) {
        printf("a is equal to b");
    } else {
        printf("a is not equal to b");
    }

    if (a != b) {
        printf("a is not equal to b");
    } else {
        printf("a is equal to b");
    }
    return 0;
}
```

## Funções

```C
#include <stdio.h>

void printar() {
    printf("Hello World");
}

int main() {
    printf("Antes de printar");
    printar();
    printf("Depois de printar");
    return 0;
}
```

```C
#include <stdio.h>

int soma(int a, int b) {
    return a + b;
}

int main() {
    int resultado = soma(10, 20);
    printf(resultado);
    return 0;
}
```

## Diretivas do Pré-processador

```C
#include <stdio.h>
#include <math>

int main() {
    int resultado = sum(10, 20);
    printf(resultado);
    return 0;
}
```

```C
#include <stdio.h>
#define testando 10

int main() {
    printf(testando);
    return 0;
}
```

## Comentários

```C
#include <stdio.h>

int main() {
    printf("Antes do comentário");
    // printf("Comentário");
    printf("Depois do comentário");
    return 0;
}
```

```C
#include <stdio.h>

int main() {
    printf("Antes do comentário");
    /* printf("Comentário 1");
    printf("Comentário 2");
    printf("Comentário 3"); */
    printf("Depois do comentário");
    return 0;
}
```

## Conclusão

Em suma, desenvolver este interpretador foi uma jornada desafiadora e gratificante.

Ao longo do processo, aprendemos muito sobre compiladores e linguagens de programação.

Enfrentamos diversos obstáculos, mas conseguimos superá-los com determinação e colaboração.

Este projeto nos proporcionou uma compreensão mais profunda dos conceitos fundamentais da computação e nos preparou para enfrentar futuros desafios com confiança.

Estamos orgulhosos do trabalho realizado e ansiosos para aplicar o que aprendemos em projetos futuros.

