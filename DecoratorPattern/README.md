⭐ What Problem Does Decorator Solve?
You want to add behavior to an object dynamically without modifying its original class and without creating a subclass explosion.
You start with a simple service:

Typical behaviors you want to add:
- Logging
- Caching
- Validation
- Retry logic
- Authorization
- Metrics
- Exception handling

If you try to do this by modifying BookService, you violate:
- Single Responsibility Principle
- Open/Closed Principle
- Clean Architecture boundaries

- If you try to do this with inheritance, you end up with multiple subclasses:
BookServiceWithLogging
BookServiceWithCaching
BookServiceWithLoggingAndCaching
BookServiceWithRetry
BookServiceWithLoggingAndRetry

This is the class explosion problem.


- With Decorator, you can create reusable components that can be combined in any way you want, without modifying the original class or creating a large number of subclasses.
That’s the same class explosion problem we saw before Bridge.
Decorator solves this by letting you wrap objects with additional behavior.

⭐ Decorator Pattern Structure (Simple & Clear)
- Component → interface or base class
- Concrete Component → the real object
- Decorator → base wrapper
- Concrete Decorators → logging, caching, retry, etc.
You can stack decorators like Lego blocks.

We’ll walk through:
- The original service (simple, clean)
- The new requirements (logging + caching + validation +Retry)
- The WRONG solution (inheritance)
- The RIGHT solution (decorator)
- The runtime call chain (how decorators wrap each other)
- Why this solves the real architectural problem

