Factory Method
================

Define uma interface para criação de um objeto, mas deixa as subclasses decidirem qual classe sera instanciada. Factory Method deixa a responsabilidade de instanciação para suas subclasses.

Participantes
-------------

* __Product__
    * Define qual a instancia de objeto que o metodo *factory method* vai criar
* __ConcreteProduct__
    * Implementa a interface Product
* __Creator__
    * declara o metodo *factory method*, que retornara um objeto do tipo Product. O Creator tambem pode definir uma implementação default do metodo *factory method* que faz a criação de um tipo default
	* Pode chamar o metodo *factory method* para criar o objeto Product
* __ConcreteCreator__
    * faz o override do metodo *factory method* para retornar a instancia de um ConcreteProduct 


### Atores - Exemplo Mundo Real
_**Product**_ _(Notebook)_

_**ConcreteProduct**_  _(SonyVaio_Fit15SVF, Inspiron_15R5437, MacBook_AirMD71)_

_**Creator**_ _(Fabricante)_

_**ConcreteCreator**_ _(Sony, Dell, Apple)_
