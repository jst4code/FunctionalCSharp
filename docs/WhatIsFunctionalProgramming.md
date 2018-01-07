# What is Functional Programming #

> **OO** makes code understandable by encapsulating moving parts.  
> **Functional Programming** makes code understandable by minimizing moving parts.

## Fundamental constructs of Functional Programming ##

1. Declarative programming
1. Pure functions (free of Side Effects)
1. Referential transparency and substitutability
1. Immutability

## Lenses ##

## Functions ##

- Expressions: Functions that produce a value
- Statements: Don't return any value
  - Assumption: Statements modify external data and cause side effects

> FP is entirely Expressional

## Power of Map, Reduce and Filter ##

C# linq equivalent of the above are:

- Map = Select | Enumerable.Range(1, 10).Select(x => x + 2);
- Reduce = Aggregate | Enumerable.Range(1, 10).Aggregate(0, (acc, x) => acc + x);
- Filter = Where | Enumerable.Range(1, 10).Where(x => x % 2 == 0);

## Function Chaining ##

## Function Pipelines ##

## Currying, Partial Application and Function Binding ##
