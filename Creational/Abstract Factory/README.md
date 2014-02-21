Abstract Factory
================

Prove uma interface para criação de varios objetos relacionados ou dependentes sem especificar suas implementações concretas

Participantes
-------------

* __AbstractFactory__
    * Declara uma interface de operadores para criação dos AbstractProducts
* __ConcreteFactory__
    * Implementa os operadores declarados por AbstracFactory que criam os objetos Product concretos
* __AbstractProduct__
    * declara a interface para o tipo objeto Product
* __Product__
    * define o objeto Product que sera criado por seu correspondente ConcreteFactory
	* implementa a interface AbstractProduct
* __Client__
    * usa as interfaces declaradas por AbstractFactory e AbstractProduct


### Exemplo
_**AbstractFactory**_ _(Fabricante)_

_**ConcreteFactory**_  _(Sony, Sansung, Apple)_

_**AbstractProduct**_ _(Notebook, Celular, Tables)_

_**Product**_ _(MacBook_AirMD71, Sansung_ATVIBook2, SonyVaio_Fit15SVF, IPhone5S, GalaxyS4, XperiaZQ, IPadAir16G, GalaxyTab3, XperiaTabletZ4G)_

_**Client**_ _(Usuario)_