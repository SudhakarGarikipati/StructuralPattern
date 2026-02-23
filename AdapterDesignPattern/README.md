🔶 1. ADAPTER PATTERN

Concept
Convert one interface into another so incompatible systems can work together.

When to Use
- Integrating a third‑party API
- Migrating from old to new systems
- Standardizing multiple providers behind one interface

- Why is this the Adaptee?
- It already exists (third‑party library, legacy code, external API)
- Its method name (SendSms) does not match your system’s expected interface (INotificationService.Send)
- You cannot modify it (because it’s external or sealed)
- You want to use it through your own interface

- So the Adapter wraps this Adaptee and converts your system’s call into something the Adaptee understands.

Client
   ↓
INotificationService (Target)
   ↓
SmsAdapter (Adapter)
   ↓
ThirdPartySmsService (Adaptee)

