  
  Which are the drawbacks and benefits to each?

  answer: main benefit of inheritance is reusability of code by inheriting all methods and properties from a base however, Inheritance offers very tight coupling between a base class and child classes, which induces heavy dependency issues from a child class to the base. If you were to change the code of a parent class. It will affect all childs. For example manipulating the FilterMeasurements method in the PointsAggregator will affect all overidden FilterMeasurements methods in all childs.

  Composition provides stronger encapsulation than inheritance, because It enables code reuse by adding a reference to another object instead of inheriting the complete implementation. However with composition, we are creating a composite object by plugging in the component objects. These component objects should not be exposed directly as they exist only within the composite context. We need to have a corresponding implementation of the component class methods in the composite class.
  This delegation of the method invocation may have a performance cost in addition to having to write extra code.
  
  Which one would you rather build on in the future? 

  answer: I would certainly go the composition route because it would be easier to implement more functionalty as i go. as Composition offers more scalability and maintainability with the expense of minimal performance.

  If had a clear goal in mind for a project with clear requirements,inheritance may be the way to go for a clear cut application. 

  Which one achieves better "reusability"?

  answer: Inheritance only aims to provide reusability from a base class to its children, whilist Composition offers reusability by decision of the user to inject dependency in any class to reuse code throughout the entire project. Therefore composition provides better reusability.



 
