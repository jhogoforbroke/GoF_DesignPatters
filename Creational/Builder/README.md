Factory Method
================

Separa a construção de objetos complexos de sua representação, sendo assim um mesmo processo de construção poderá criar diferentes representações

Participantes
-------------

* __Builder__
    * Específica uma interface abstrata para criar partes de um objeto Product 
* __ConcreteBuilder__
    * Constroi e monta as partes de um Product de acordo com a implementação da interface Builder
	* Define e mantem o controle da representação que sera criada
	* Prove um interface para recuperar o Product
* __Director__
    * Constroi o objeto usando a interface Builder
* __Product__
    * Representa o objeto complexo que sera construido. O ConcreteBuilder contruirá as partes internas do Product e definirá qual o processo pelo qual ele será montado.
	* Inclui classes que definem as partes constituintes, incluindo interfaces que estabeleceram como será montada cada peça para obeter o resultado final.

### Atores - Exemplo Mundo Real
_**Product**_ _(Notebook)_

_**ConcreteProduct**_  _(SonyVaio_Fit15SVF, Inspiron_15R5437, MacBook_AirMD71)_

_**Creator**_ _(Fabricante)_

_**ConcreteCreator**_ _(Sony, Dell, Apple)_
