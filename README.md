## 📘 Conceitos Fundamentais

### 🔹 POO (Programação Orientada a Objetos)
> Paradigma de programação que organiza o software em unidades chamadas objetos.

#### ⚙️ Características
- Reutilização de código
- Facilidade de manutenção
- Encapsulamento

#### 🧱 Pilares da POO
- **Abstração**
- **Encapsulamento**
- **Herança**
- **Polimorfismo**

---

## 🧩 Elementos da POO

### 📦 Classe
Molde para criar objetos. Exemplo: `Carro`, `Pessoa`.

### 🎯 Objeto
Instância concreta de uma classe.

### 📝 Atributos
Características dos objetos definidos na classe.

### 🔧 Métodos
Funções/ações que os objetos podem executar.

---

## 🔐 Encapsulamento
> Controla a visibilidade de atributos e métodos.

### 🛡️ Modificadores de Acesso:
- `public`: acessível de qualquer lugar
- `private`: acessível somente na própria classe
- `protected`: acessível na classe e em subclasses

### 🧪 Get e Set
- `get`: retorna o valor de um atributo
- `set`: define o valor de um atributo

---

## 🏗️ Construtores
> Método especial chamado automaticamente ao instanciar um objeto.  
Serve para **inicializar** o estado do objeto.

---

## ⚡ Atributos e Métodos Estáticos
> Pertencem à própria classe, e **não** exigem instância para serem acessados.

---

## 👨‍👩‍👧 Herança
> Permite que uma classe herde características de outra.

```csharp
class Pessoa {
    public string Nome;
}

class Aluno : Pessoa {
    public int Matricula;
}
