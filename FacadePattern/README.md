⭐ Facade Pattern

- Facade solves complexity reduction
It’s a very different kind of pattern — instead of wrapping one object (Decorator), Facade wraps an entire subsystem and gives the client a simple API.

Imagine you have a complex subsystem:
The client must call all of them in the right order.
Facade gives you a simple unified interface

FacadePattern/
│
├── Subsystems/
│     ├── InventoryService.cs
│     ├── PaymentService.cs
│     ├── ShippingService.cs
│     └── NotificationService.cs
│
├── Facade/
│     └── OrderFacade.cs
│
└── Client/
      └── FacadeClient.cs

The Facade Pattern provides a simplified interface to a complex subsystem.
In this example, OrderFacade hides the complexity of multiple services—InventoryService, PaymentService, ShippingService, and NotificationService—and exposes a single PlaceOrder method.
This reduces coupling, improves readability, and makes the client code significantly easier to maintain.

